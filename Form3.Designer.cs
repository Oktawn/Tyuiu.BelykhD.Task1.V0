﻿namespace Tyuiu.BelykhD.Task1.V0
{
    partial class Form3
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
            this.label_Revenue = new System.Windows.Forms.Label();
            this.label_minCost = new System.Windows.Forms.Label();
            this.label_mCost = new System.Windows.Forms.Label();
            this.textBox_Revenue = new System.Windows.Forms.TextBox();
            this.textBox_mnCost = new System.Windows.Forms.TextBox();
            this.textBox_mxCost = new System.Windows.Forms.TextBox();
            this.label_avg = new System.Windows.Forms.Label();
            this.textBox_avg = new System.Windows.Forms.TextBox();
            this.label_count = new System.Windows.Forms.Label();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Revenue
            // 
            this.label_Revenue.AutoSize = true;
            this.label_Revenue.Location = new System.Drawing.Point(28, 45);
            this.label_Revenue.Name = "label_Revenue";
            this.label_Revenue.Size = new System.Drawing.Size(46, 13);
            this.label_Revenue.TabIndex = 0;
            this.label_Revenue.Text = "revenue";
            // 
            // label_minCost
            // 
            this.label_minCost.AutoSize = true;
            this.label_minCost.Location = new System.Drawing.Point(28, 82);
            this.label_minCost.Name = "label_minCost";
            this.label_minCost.Size = new System.Drawing.Size(46, 13);
            this.label_minCost.TabIndex = 1;
            this.label_minCost.Text = "min cost";
            // 
            // label_mCost
            // 
            this.label_mCost.AutoSize = true;
            this.label_mCost.Location = new System.Drawing.Point(28, 126);
            this.label_mCost.Name = "label_mCost";
            this.label_mCost.Size = new System.Drawing.Size(49, 13);
            this.label_mCost.TabIndex = 2;
            this.label_mCost.Text = "max cost";
            // 
            // textBox_Revenue
            // 
            this.textBox_Revenue.Location = new System.Drawing.Point(94, 45);
            this.textBox_Revenue.Name = "textBox_Revenue";
            this.textBox_Revenue.ReadOnly = true;
            this.textBox_Revenue.Size = new System.Drawing.Size(100, 20);
            this.textBox_Revenue.TabIndex = 3;
            // 
            // textBox_mnCost
            // 
            this.textBox_mnCost.Location = new System.Drawing.Point(94, 82);
            this.textBox_mnCost.Name = "textBox_mnCost";
            this.textBox_mnCost.ReadOnly = true;
            this.textBox_mnCost.Size = new System.Drawing.Size(100, 20);
            this.textBox_mnCost.TabIndex = 4;
            // 
            // textBox_mxCost
            // 
            this.textBox_mxCost.Location = new System.Drawing.Point(94, 123);
            this.textBox_mxCost.Name = "textBox_mxCost";
            this.textBox_mxCost.ReadOnly = true;
            this.textBox_mxCost.Size = new System.Drawing.Size(100, 20);
            this.textBox_mxCost.TabIndex = 5;
            // 
            // label_avg
            // 
            this.label_avg.AutoSize = true;
            this.label_avg.Location = new System.Drawing.Point(28, 163);
            this.label_avg.Name = "label_avg";
            this.label_avg.Size = new System.Drawing.Size(48, 13);
            this.label_avg.TabIndex = 6;
            this.label_avg.Text = "avg cost";
            // 
            // textBox_avg
            // 
            this.textBox_avg.Location = new System.Drawing.Point(94, 160);
            this.textBox_avg.Name = "textBox_avg";
            this.textBox_avg.ReadOnly = true;
            this.textBox_avg.Size = new System.Drawing.Size(100, 20);
            this.textBox_avg.TabIndex = 7;
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(28, 195);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(61, 13);
            this.label_count.TabIndex = 8;
            this.label_count.Text = "count order";
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(94, 192);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.ReadOnly = true;
            this.textBox_count.Size = new System.Drawing.Size(100, 20);
            this.textBox_count.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 283);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.textBox_avg);
            this.Controls.Add(this.label_avg);
            this.Controls.Add(this.textBox_mxCost);
            this.Controls.Add(this.textBox_mnCost);
            this.Controls.Add(this.textBox_Revenue);
            this.Controls.Add(this.label_mCost);
            this.Controls.Add(this.label_minCost);
            this.Controls.Add(this.label_Revenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Revenue;
        private System.Windows.Forms.Label label_minCost;
        private System.Windows.Forms.Label label_mCost;
        private System.Windows.Forms.TextBox textBox_Revenue;
        private System.Windows.Forms.TextBox textBox_mnCost;
        private System.Windows.Forms.TextBox textBox_mxCost;
        private System.Windows.Forms.Label label_avg;
        private System.Windows.Forms.TextBox textBox_avg;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.TextBox textBox_count;
    }
}