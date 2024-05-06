namespace Tyuiu.BelykhD.Task1.V0
{
    partial class AProgramm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AProgramm));
            this.richTextBox_text = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox_text
            // 
            this.richTextBox_text.Enabled = false;
            this.richTextBox_text.Location = new System.Drawing.Point(3, 12);
            this.richTextBox_text.Name = "richTextBox_text";
            this.richTextBox_text.ReadOnly = true;
            this.richTextBox_text.Size = new System.Drawing.Size(502, 270);
            this.richTextBox_text.TabIndex = 0;
            this.richTextBox_text.TabStop = false;
            this.richTextBox_text.Text = resources.GetString("richTextBox_text.Text");
            // 
            // AProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 303);
            this.Controls.Add(this.richTextBox_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AProgramm";
            this.Text = "About programm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_text;
    }
}