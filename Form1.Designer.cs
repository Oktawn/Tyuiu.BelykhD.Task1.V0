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
            this.dataGridView1_Table = new System.Windows.Forms.DataGridView();
            this.Column_car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Master = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_Table
            // 
            this.dataGridView1_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_car,
            this.Column_Phone,
            this.Column_Master,
            this.Column_Service,
            this.Column_Price,
            this.Column_date});
            this.dataGridView1_Table.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1_Table.Name = "dataGridView1_Table";
            this.dataGridView1_Table.Size = new System.Drawing.Size(646, 278);
            this.dataGridView1_Table.TabIndex = 0;
            // 
            // Column_car
            // 
            this.Column_car.HeaderText = "№ car";
            this.Column_car.MaxInputLength = 9;
            this.Column_car.Name = "Column_car";
            this.Column_car.ToolTipText = "number car";
            // 
            // Column_Phone
            // 
            this.Column_Phone.HeaderText = "Phone";
            this.Column_Phone.MaxInputLength = 12;
            this.Column_Phone.Name = "Column_Phone";
            this.Column_Phone.ToolTipText = "Owner\'s phone number";
            // 
            // Column_Master
            // 
            this.Column_Master.HeaderText = "Master";
            this.Column_Master.MaxInputLength = 40;
            this.Column_Master.Name = "Column_Master";
            this.Column_Master.ToolTipText = "FIO Master";
            // 
            // Column_Service
            // 
            this.Column_Service.HeaderText = "Service";
            this.Column_Service.Name = "Column_Service";
            // 
            // Column_Price
            // 
            this.Column_Price.HeaderText = "Price";
            this.Column_Price.Name = "Column_Price";
            this.Column_Price.ToolTipText = "Cost service";
            // 
            // Column_date
            // 
            this.Column_date.HeaderText = "Date Complite";
            this.Column_date.Name = "Column_date";
            this.Column_date.ToolTipText = "When the job is done";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1_Table);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_car;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Master;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_date;
    }
}

