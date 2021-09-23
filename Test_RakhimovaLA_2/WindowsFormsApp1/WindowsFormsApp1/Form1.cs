using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlCommandBuilder sqlBuilder = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;
        private bool newRowAdding = false;
        private string sql_text;
        
        public Form1()
        {
            InitializeComponent();
        }

        /*Вывод данных в Grid, select передается параметром*/
        private void OpenReport(string textSql)
        {
            dataGridView1.Visible = true;

            try 
            {
                sqlDataAdapter = new SqlDataAdapter(textSql, sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "employee");
                dataGridView1.DataSource = dataSet.Tables["employee"];

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        { 
            /*Подключение к БД*/
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();

            dataGridView1.Visible = false;
                        
        }

       

        private void WithChiefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql_text = "Select dp.id, department_name, sum(salary) as [SumSalary]  " +
                "   from employee emp left join department dp on emp.department_id = dp.id " +
                "   where isnull(emp.logical_delete,'false') = 'false' group by dp.id, department_name";
            OpenReport(sql_text);

            label1.Text = "Суммарная зарплата в разрезе департаментов с руководителями";
        }

        private void withoutChiefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql_text = "Select dp.id, department_name, sum(salary) as [SumSalary]  " +
                "       from employee emp " +
                "           left join department dp on emp.department_id = dp.id " +
                "       where isnull(emp.Id, 0) not in (select distinct cheif_id from employee where cheif_id is not null) and isnull(emp.logical_delete,'false') = 'false'  " +
                "       group by dp.id, department_name";
            OpenReport(sql_text);

            label1.Text = "Суммарная зарплата в разрезе департаментов ,без руководителей";
        }

        private void Select2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql_text = "Select top 1 dp.id, department_name, max(salary) as [Salary]  " +
                "       from employee emp " +
                "           left join department dp on emp.department_id = dp.id " +
                "       where isnull(emp.logical_delete,'false') = 'false'" +
                "       group by dp.id, department_name order by 3 desc";
            OpenReport(sql_text);

            
            label1.Text = "Департамент, в котором у сотрудника зарплата максимальна";
        }

        private void Select3TollStripMenuItem_Click(object sender, EventArgs e)
        {
            sql_text = "Select distinct ch.id, ch.employee_name" +
                "           , (select department_name from department where emp.department_id = department.id) as deparment_boss" +
                "           , ch.salary  " +
                "       from employee emp " +
                "           inner join employee ch on ch.id = emp.cheif_id " +
                "        where isnull(emp.logical_delete,'false') = 'false'" +
               
                "       order by ch.salary desc";
            OpenReport(sql_text);
            label1.Text = "Зарплаты руководителей департаментов (по убыванию)";
        }

        

        private void DepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql_text = "Select * from department ";
            OpenReport(sql_text);
            label1.Text = "Справочник 'Наши организации'";

            /*for(int i=0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                dataGridView1[2, i] = linkCell;
            }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6 )
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(); //берем значение с последнего столбца текущей строки

                    if (task == "Insert")
                    {
                        int rowIndex = dataGridView1.Rows.Count-2;
                        DataRow row = dataSet.Tables["employee"].NewRow();

                        /*Записываем значения из Grid в DataSet*/
                        row["employee_name"] = dataGridView1.Rows[rowIndex].Cells["employee_name"].Value;
                        row["department_id"] = dataGridView1.Rows[rowIndex].Cells["department_id"].Value;
                        row["cheif_id"] = dataGridView1.Rows[rowIndex].Cells["cheif_id"].Value;
                        row["salary"] = dataGridView1.Rows[rowIndex].Cells["salary"].Value;
                        row["logical_delete"] = dataGridView1.Rows[rowIndex].Cells["logical_delete"].Value;

                        dataSet.Tables["employee"].Rows.Add(row);
                        dataSet.Tables["employee"].Rows.RemoveAt(dataSet.Tables["employee"].Rows.Count-1);
                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);
                        dataGridView1.Rows[e.RowIndex].Cells[6].Value = "Update";
                        sqlDataAdapter.Update(dataSet,"employee"); // Записывем из Dataset в Базу данных
                        newRowAdding = false;
                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;
                        dataSet.Tables["employee"].Rows[r]["employee_name"] = dataGridView1.Rows[r].Cells["employee_name"].Value;
                        dataSet.Tables["employee"].Rows[r]["department_id"] = dataGridView1.Rows[r].Cells["department_id"].Value;
                        dataSet.Tables["employee"].Rows[r]["cheif_id"] = dataGridView1.Rows[r].Cells["cheif_id"].Value;
                        dataSet.Tables["employee"].Rows[r]["salary"] = dataGridView1.Rows[r].Cells["salary"].Value;
                        dataSet.Tables["employee"].Rows[r]["logical_delete"] = dataGridView1.Rows[r].Cells["logical_delete"].Value;

                        sqlDataAdapter.Update(dataSet, "employee");
                        dataGridView1.Rows[e.RowIndex].Cells[6].Value = "Update";

                    }
                    OpenReport(sql_text);

                    if (label1.Text == "Справочник 'Сотрудники'")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                            dataGridView1[6, i] = linkCell;
                        }
                    }
                            
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        /*Событие при создании новой строки в таблице "Сотрудники"*/
        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;

                    int lastRow = dataGridView1.Rows.Count - 2;
                    DataGridViewRow row = dataGridView1.Rows[lastRow];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[6, lastRow] = linkCell;
                    row.Cells["Update"].Value = "Insert";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql_text = "Select *, 'Update'  as [Update] from employee ";
            OpenReport(sql_text);
            label1.Text = "Таблица 'Сотрудники'";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                dataGridView1[6, i] = linkCell;

                
            }
        }
        /*событие при изменении существующей строки в таблице Сотрудники*/
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;

                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow editingRow = dataGridView1.Rows[rowIndex];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[6, rowIndex] = linkCell;
                    editingRow.Cells["Update"].Value = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
