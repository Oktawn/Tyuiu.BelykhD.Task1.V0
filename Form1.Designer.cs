namespace Tyuiu.BelykhD.Task1.V0
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1_Table = new System.Windows.Forms.DataGridView();
            this.button_AddOrder = new System.Windows.Forms.Button();
            this.button_Stats = new System.Windows.Forms.Button();
            this.toolTip_Order = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_Stats = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox_Programm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox_guide = new System.Windows.Forms.ToolStripMenuItem();
            this.label_SearchCar = new System.Windows.Forms.Label();
            this.textBox_SearchCar = new System.Windows.Forms.TextBox();
            this.comboBox_Filter = new System.Windows.Forms.ComboBox();
            this.textBox_Filter = new System.Windows.Forms.TextBox();
            this.button_Filter = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Table)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1_Table
            // 
            this.dataGridView1_Table.AllowUserToAddRows = false;
            this.dataGridView1_Table.AllowUserToDeleteRows = false;
            this.dataGridView1_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Table.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1_Table.Name = "dataGridView1_Table";
            this.dataGridView1_Table.Size = new System.Drawing.Size(773, 278);
            this.dataGridView1_Table.TabIndex = 0;
            // 
            // button_AddOrder
            // 
            this.button_AddOrder.Location = new System.Drawing.Point(12, 379);
            this.button_AddOrder.Name = "button_AddOrder";
            this.button_AddOrder.Size = new System.Drawing.Size(75, 23);
            this.button_AddOrder.TabIndex = 1;
            this.button_AddOrder.Text = "Add order";
            this.button_AddOrder.UseVisualStyleBackColor = true;
            this.button_AddOrder.Click += new System.EventHandler(this.Button_AddOrder_Click);
            // 
            // button_Stats
            // 
            this.button_Stats.Location = new System.Drawing.Point(107, 379);
            this.button_Stats.Name = "button_Stats";
            this.button_Stats.Size = new System.Drawing.Size(75, 23);
            this.button_Stats.TabIndex = 2;
            this.button_Stats.Text = "Stats";
            this.button_Stats.UseVisualStyleBackColor = true;
            this.button_Stats.Click += new System.EventHandler(this.Button_Stats_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.свойстваToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox_Programm,
            this.toolStripTextBox_guide});
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            this.свойстваToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.свойстваToolStripMenuItem.Text = "Свойства";
            // 
            // toolStripTextBox_Programm
            // 
            this.toolStripTextBox_Programm.Name = "toolStripTextBox_Programm";
            this.toolStripTextBox_Programm.Size = new System.Drawing.Size(221, 22);
            this.toolStripTextBox_Programm.Text = "О программе";
            this.toolStripTextBox_Programm.Click += new System.EventHandler(this.ToolStripTextBox_Programm_Click);
            // 
            // toolStripTextBox_guide
            // 
            this.toolStripTextBox_guide.Name = "toolStripTextBox_guide";
            this.toolStripTextBox_guide.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripTextBox_guide.Size = new System.Drawing.Size(221, 22);
            this.toolStripTextBox_guide.Text = "Руководтсво пользователя";
            this.toolStripTextBox_guide.Click += new System.EventHandler(this.ToolStripTextBox2_Click);
            // 
            // label_SearchCar
            // 
            this.label_SearchCar.AutoSize = true;
            this.label_SearchCar.Location = new System.Drawing.Point(616, 384);
            this.label_SearchCar.Name = "label_SearchCar";
            this.label_SearchCar.Size = new System.Drawing.Size(73, 13);
            this.label_SearchCar.TabIndex = 6;
            this.label_SearchCar.Text = "Search by car";
            // 
            // textBox_SearchCar
            // 
            this.textBox_SearchCar.Location = new System.Drawing.Point(702, 381);
            this.textBox_SearchCar.Name = "textBox_SearchCar";
            this.textBox_SearchCar.Size = new System.Drawing.Size(100, 20);
            this.textBox_SearchCar.TabIndex = 7;
            this.textBox_SearchCar.TextChanged += new System.EventHandler(this.TextBox_SearchCar_TextChanged);
            // 
            // comboBox_Filter
            // 
            this.comboBox_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Filter.FormattingEnabled = true;
            this.comboBox_Filter.Items.AddRange(new object[] {
            "Date Complite",
            "Master"});
            this.comboBox_Filter.Location = new System.Drawing.Point(270, 379);
            this.comboBox_Filter.Name = "comboBox_Filter";
            this.comboBox_Filter.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Filter.TabIndex = 8;
            // 
            // textBox_Filter
            // 
            this.textBox_Filter.Location = new System.Drawing.Point(450, 381);
            this.textBox_Filter.Name = "textBox_Filter";
            this.textBox_Filter.Size = new System.Drawing.Size(100, 20);
            this.textBox_Filter.TabIndex = 10;
            // 
            // button_Filter
            // 
            this.button_Filter.Location = new System.Drawing.Point(270, 420);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(75, 23);
            this.button_Filter.TabIndex = 11;
            this.button_Filter.Text = "Click";
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.Button_Filter_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(475, 420);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 12;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 455);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Filter);
            this.Controls.Add(this.textBox_Filter);
            this.Controls.Add(this.comboBox_Filter);
            this.Controls.Add(this.textBox_SearchCar);
            this.Controls.Add(this.label_SearchCar);
            this.Controls.Add(this.button_Stats);
            this.Controls.Add(this.button_AddOrder);
            this.Controls.Add(this.dataGridView1_Table);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Table)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_Table;
        private System.Windows.Forms.Button button_AddOrder;
        private System.Windows.Forms.Button button_Stats;
        private System.Windows.Forms.ToolTip toolTip_Order;
        private System.Windows.Forms.ToolTip toolTip_Stats;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox_Programm;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox_guide;
        private System.Windows.Forms.Label label_SearchCar;
        private System.Windows.Forms.TextBox textBox_SearchCar;
        private System.Windows.Forms.ComboBox comboBox_Filter;
        private System.Windows.Forms.TextBox textBox_Filter;
        private System.Windows.Forms.Button button_Filter;
        private System.Windows.Forms.Button button_Clear;
    }
}

