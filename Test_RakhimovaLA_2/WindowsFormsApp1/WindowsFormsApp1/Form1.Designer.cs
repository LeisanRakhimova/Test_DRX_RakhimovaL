
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сформироватьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.суммарнаяЗарплатаВРазрезеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WithChiefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withoutChiefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Select2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Select3TollStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьФормуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сформироватьОтчетToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.закрытьФормуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сформироватьОтчетToolStripMenuItem
            // 
            this.сформироватьОтчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.суммарнаяЗарплатаВРазрезеToolStripMenuItem,
            this.Select2ToolStripMenuItem,
            this.Select3TollStripMenuItem});
            this.сформироватьОтчетToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.сформироватьОтчетToolStripMenuItem.Name = "сформироватьОтчетToolStripMenuItem";
            this.сформироватьОтчетToolStripMenuItem.Size = new System.Drawing.Size(191, 27);
            this.сформироватьОтчетToolStripMenuItem.Text = "Сформировать отчет";
            // 
            // суммарнаяЗарплатаВРазрезеToolStripMenuItem
            // 
            this.суммарнаяЗарплатаВРазрезеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WithChiefToolStripMenuItem,
            this.withoutChiefToolStripMenuItem});
            this.суммарнаяЗарплатаВРазрезеToolStripMenuItem.Name = "суммарнаяЗарплатаВРазрезеToolStripMenuItem";
            this.суммарнаяЗарплатаВРазрезеToolStripMenuItem.Size = new System.Drawing.Size(581, 28);
            this.суммарнаяЗарплатаВРазрезеToolStripMenuItem.Text = "Суммарная зарплата в разрезе департаментов";
            // 
            // WithChiefToolStripMenuItem
            // 
            this.WithChiefToolStripMenuItem.Name = "WithChiefToolStripMenuItem";
            this.WithChiefToolStripMenuItem.Size = new System.Drawing.Size(253, 28);
            this.WithChiefToolStripMenuItem.Text = "с руководитеями ";
            this.WithChiefToolStripMenuItem.Click += new System.EventHandler(this.WithChiefToolStripMenuItem_Click);
            // 
            // withoutChiefToolStripMenuItem
            // 
            this.withoutChiefToolStripMenuItem.Name = "withoutChiefToolStripMenuItem";
            this.withoutChiefToolStripMenuItem.Size = new System.Drawing.Size(253, 28);
            this.withoutChiefToolStripMenuItem.Text = "без руководиетелей";
            this.withoutChiefToolStripMenuItem.Click += new System.EventHandler(this.withoutChiefToolStripMenuItem_Click);
            // 
            // Select2ToolStripMenuItem
            // 
            this.Select2ToolStripMenuItem.Name = "Select2ToolStripMenuItem";
            this.Select2ToolStripMenuItem.Size = new System.Drawing.Size(581, 28);
            this.Select2ToolStripMenuItem.Text = "Департамент, в котором у сотрудника зарплата максимальна";
            this.Select2ToolStripMenuItem.Click += new System.EventHandler(this.Select2ToolStripMenuItem_Click);
            // 
            // Select3TollStripMenuItem
            // 
            this.Select3TollStripMenuItem.Name = "Select3TollStripMenuItem";
            this.Select3TollStripMenuItem.Size = new System.Drawing.Size(581, 28);
            this.Select3TollStripMenuItem.Text = "Зарплаты руководителей департаментов (по убыванию)";
            this.Select3TollStripMenuItem.Click += new System.EventHandler(this.Select3TollStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DepartmentToolStripMenuItem,
            this.EmployeeToolStripMenuItem});
            this.справочникиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(93, 27);
            this.справочникиToolStripMenuItem.Text = "Таблицы";
            // 
            // DepartmentToolStripMenuItem
            // 
            this.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem";
            this.DepartmentToolStripMenuItem.Size = new System.Drawing.Size(247, 28);
            this.DepartmentToolStripMenuItem.Text = "Наши организации";
            this.DepartmentToolStripMenuItem.Click += new System.EventHandler(this.DepartmentToolStripMenuItem_Click);
            // 
            // EmployeeToolStripMenuItem
            // 
            this.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem";
            this.EmployeeToolStripMenuItem.Size = new System.Drawing.Size(247, 28);
            this.EmployeeToolStripMenuItem.Text = "Сотрудники";
            this.EmployeeToolStripMenuItem.Click += new System.EventHandler(this.EmployeeToolStripMenuItem_Click);
            // 
            // закрытьФормуToolStripMenuItem
            // 
            this.закрытьФормуToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.закрытьФормуToolStripMenuItem.Name = "закрытьФормуToolStripMenuItem";
            this.закрытьФормуToolStripMenuItem.Size = new System.Drawing.Size(117, 27);
            this.закрытьФормуToolStripMenuItem.Text = "Инструкция";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(800, 366);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Главная страница";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem сформироватьОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem суммарнаяЗарплатаВРазрезеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WithChiefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withoutChiefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Select2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Select3TollStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьФормуToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

