using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            ShowChart();
            
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
            textBox_avg.Text = (sum / dataGridView1_Table.Rows.Count).ToString();
            textBox_count.Text=dataGridView1_Table.Rows.Count.ToString();
        }

        private void ShowChart()
        {

            int col = 5;
            long sum = 0;
            var area = new ChartArea();
            area.AxisX.Title = "Count order";
            area.AxisY.Title = "Sum";
            

            var series = new Series();
            chart_Gragh.ChartAreas.Add(area);
            chart_Gragh.Series.Add(series);

            for (int i = 0; i < dataGridView1_Table.Rows.Count; i++)
            {
                sum+= Convert.ToInt64(dataGridView1_Table.Rows[i].Cells[col].Value);
                series.Points.AddXY(i,sum);
            }


        }

    }
}
