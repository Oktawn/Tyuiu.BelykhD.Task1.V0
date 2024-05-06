namespace Tyuiu.BelykhD.Task1.V0
{
    partial class Authorization
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
            this.label_login = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.button_SignIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maskedTextBox_pass = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(25, 103);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(33, 13);
            this.label_login.TabIndex = 0;
            this.label_login.Text = "Login";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(25, 177);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(53, 13);
            this.label_pass.TabIndex = 1;
            this.label_pass.Text = "Password";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(127, 103);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 2;
            // 
            // button_SignIn
            // 
            this.button_SignIn.Location = new System.Drawing.Point(136, 253);
            this.button_SignIn.Name = "button_SignIn";
            this.button_SignIn.Size = new System.Drawing.Size(75, 23);
            this.button_SignIn.TabIndex = 4;
            this.button_SignIn.Text = "Sign In";
            this.button_SignIn.UseVisualStyleBackColor = true;
            this.button_SignIn.Click += new System.EventHandler(this.Button_SignIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.BelykhD.Task1.V0.Properties.Resources.museum;
            this.pictureBox1.Location = new System.Drawing.Point(127, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // maskedTextBox_pass
            // 
            this.maskedTextBox_pass.Location = new System.Drawing.Point(127, 174);
            this.maskedTextBox_pass.Name = "maskedTextBox_pass";
            this.maskedTextBox_pass.PasswordChar = '*';
            this.maskedTextBox_pass.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_pass.TabIndex = 3;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 378);
            this.Controls.Add(this.maskedTextBox_pass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_SignIn);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Button button_SignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_pass;
    }
}

