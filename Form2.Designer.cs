namespace Tyuiu.BelykhD.Task1.V0
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox_Car = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Phone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_DataComplite = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Service = new System.Windows.Forms.TextBox();
            this.textBox_Cost = new System.Windows.Forms.TextBox();
            this.comboBox_Master = new System.Windows.Forms.ComboBox();
            this.button_CreateOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "№ car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Owner\'s phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Master";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "The cost of the order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Work completion time";
            // 
            // maskedTextBox_Car
            // 
            this.maskedTextBox_Car.Location = new System.Drawing.Point(174, 48);
            this.maskedTextBox_Car.Mask = "L000LL 00";
            this.maskedTextBox_Car.Name = "maskedTextBox_Car";
            this.maskedTextBox_Car.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Car.TabIndex = 12;
            // 
            // maskedTextBox_Phone
            // 
            this.maskedTextBox_Phone.Location = new System.Drawing.Point(174, 85);
            this.maskedTextBox_Phone.Mask = "+7-000-000-00-00";
            this.maskedTextBox_Phone.Name = "maskedTextBox_Phone";
            this.maskedTextBox_Phone.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Phone.TabIndex = 13;
            // 
            // maskedTextBox_DataComplite
            // 
            this.maskedTextBox_DataComplite.Location = new System.Drawing.Point(174, 248);
            this.maskedTextBox_DataComplite.Mask = "00.00.0000";
            this.maskedTextBox_DataComplite.Name = "maskedTextBox_DataComplite";
            this.maskedTextBox_DataComplite.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_DataComplite.TabIndex = 17;
            this.maskedTextBox_DataComplite.ValidatingType = typeof(System.DateTime);
            // 
            // textBox_Service
            // 
            this.textBox_Service.Location = new System.Drawing.Point(174, 165);
            this.textBox_Service.MaxLength = 100;
            this.textBox_Service.Name = "textBox_Service";
            this.textBox_Service.Size = new System.Drawing.Size(100, 20);
            this.textBox_Service.TabIndex = 18;
            // 
            // textBox_Cost
            // 
            this.textBox_Cost.Location = new System.Drawing.Point(174, 206);
            this.textBox_Cost.MaxLength = 10;
            this.textBox_Cost.Name = "textBox_Cost";
            this.textBox_Cost.Size = new System.Drawing.Size(100, 20);
            this.textBox_Cost.TabIndex = 19;
            this.textBox_Cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Cost_KeyPress);
            // 
            // comboBox_Master
            // 
            this.comboBox_Master.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Master.FormattingEnabled = true;
            this.comboBox_Master.Items.AddRange(new object[] {
            "Климов К. М.",
            "Носова М. П.",
            "Миронова В. В.",
            "Кириллов А. М.",
            "Васильева У. М."});
            this.comboBox_Master.Location = new System.Drawing.Point(174, 128);
            this.comboBox_Master.Name = "comboBox_Master";
            this.comboBox_Master.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Master.TabIndex = 20;
            // 
            // button_CreateOrder
            // 
            this.button_CreateOrder.Location = new System.Drawing.Point(34, 298);
            this.button_CreateOrder.Name = "button_CreateOrder";
            this.button_CreateOrder.Size = new System.Drawing.Size(75, 23);
            this.button_CreateOrder.TabIndex = 21;
            this.button_CreateOrder.Text = "Create Order";
            this.button_CreateOrder.UseVisualStyleBackColor = true;
            this.button_CreateOrder.Click += new System.EventHandler(this.Button_CreateOrder_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 355);
            this.Controls.Add(this.button_CreateOrder);
            this.Controls.Add(this.comboBox_Master);
            this.Controls.Add(this.textBox_Cost);
            this.Controls.Add(this.textBox_Service);
            this.Controls.Add(this.maskedTextBox_DataComplite);
            this.Controls.Add(this.maskedTextBox_Phone);
            this.Controls.Add(this.maskedTextBox_Car);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Order";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Car;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Phone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_DataComplite;
        private System.Windows.Forms.TextBox textBox_Service;
        private System.Windows.Forms.TextBox textBox_Cost;
        private System.Windows.Forms.ComboBox comboBox_Master;
        private System.Windows.Forms.Button button_CreateOrder;
    }
}