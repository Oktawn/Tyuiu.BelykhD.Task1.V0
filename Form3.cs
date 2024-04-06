using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.BelykhD.Task1.V0
{
    public partial class Form3 : Form
    {
        private DataGridView dataGridView1_Table;

        public Form3()
        {
        }

        public Form3(DataGridView dataGridView1_Table)
        {
            InitializeComponent();
            this.dataGridView1_Table = dataGridView1_Table;
            ShowRevenue();
        }

        private void ShowRevenue()
        {
            long sum = 0;
            long min = int.MaxValue;
            long max = int.MinValue;
            int col = 5;
            for (int i = 0; i < dataGridView1_Table.Rows.Count; i++)
            {
                long temp = Convert.ToInt64(dataGridView1_Table.Rows[i].Cells[col].Value);
                sum += temp;

                if (temp < min)
                    min = temp;

                if (temp > max)
                    max = temp;
            }
            textBox_Revenue.Text = sum.ToString();
            textBox_mnCost.Text = min.ToString();
            textBox_mxCost.Text = max.ToString();
        }

    }
}
