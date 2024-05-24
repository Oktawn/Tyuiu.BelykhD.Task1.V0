using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tyuiu.BelykhD.Task1.V0
{
    public partial class FormMain_BelykhDM : Form
    {
        readonly string pathDB = "DB.csv";
        private readonly DataTable dt = new DataTable();

        public FormMain_BelykhDM()
        {
            InitializeComponent();
            LoadCSV_BelykhDM(pathDB);
            toolTip_Order.SetToolTip(button_AddOrder, "Add order");
            toolTip_Stats.SetToolTip(button_Stats, "show stats");
        }


        private void LoadCSV_BelykhDM(string pathDB)
        {
            foreach (var item in File.ReadLines(pathDB).ElementAtOrDefault(0).Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
            {
                dt.Columns.Add(item);
            }


            foreach (var line in File.ReadLines(pathDB).Skip(1))
            {
                dt.Rows.Add(line.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries));

            }
            dataGridView1_Table.DataSource = dt;

        }
        private void SaveCSV_BelykhDM()
        {
            StringBuilder csv = new StringBuilder();

            for (int i = 0; i < dataGridView1_Table.Columns.Count; i++)
            {
                csv.Append(dataGridView1_Table.Columns[i].HeaderText + ";");
            }
            csv.Append("\n");

            for (int i = 0; i < dataGridView1_Table.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1_Table.Columns.Count; j++)
                {
                    csv.Append(dataGridView1_Table.Rows[i].Cells[j].Value + ";");
                }
                csv.Append("\n");
            }

            File.WriteAllText(pathDB, csv.ToString());
        }

        private void Form1_FormClosing_BelykhDM(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Хотите сохранить данные перед закрытием?", "Сохранение данных", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SaveCSV_BelykhDM();
            }
        }

        private void Button_AddOrder_Click_BelykhDM(object sender, EventArgs e)
        {
            Order form2 = new Order(DataTable: dt);
            form2.Show();
        }

        private void Button_Stats_Click_BelykhDM(object sender, EventArgs e)
        {
            FormStats_BelykhDM form3 = new FormStats_BelykhDM(dataGridView1_Table: dataGridView1_Table);
            form3.Show();
        }

        private void ToolStripTextBox_Programm_Click_BelykhDM(object sender, EventArgs e)
        {
            FormAbout_BelykhDM form4 = new FormAbout_BelykhDM();
            form4.Show();
        }

        private void ToolStripTextBox2_Click_BelykhDM(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "text.docx";
            process.Start();

        }

        private void TextBox_SearchCar_TextChanged_BelykhDM(object sender, EventArgs e)
        {
            var search = textBox_SearchCar.Text;
            dataGridView1_Table.ClearSelection();
            if (string.IsNullOrEmpty(search))
                return;

            dataGridView1_Table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in dataGridView1_Table.Rows)
            {
                row.Selected = false;
                DataGridViewCell cell = row.Cells[1];

                if (cell.Value != null && cell.Value.ToString().ToLower().Contains(search.ToLower()))
                    row.Selected = true;
            }
        }

        BindingSource bs = new BindingSource();
        private void Button_Filter_Click_BelykhDM(object sender, EventArgs e)
        {
            try
            {
                string filterText = textBox_Filter?.Text;
                string filterRow = comboBox_Filter.SelectedItem?.ToString();

                bs.DataSource = dt;
                bs.Filter = $"[{filterRow}] LIKE '%{filterText}%'";
                dataGridView1_Table.DataSource = bs;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при применении фильтра: {ex.Message}\n\n{ex.StackTrace}");
            }
        }

        private void Button_Clear_Click_BelykhDM(object sender, EventArgs e)
        {
            bs.RemoveFilter();
        }
    }
}
