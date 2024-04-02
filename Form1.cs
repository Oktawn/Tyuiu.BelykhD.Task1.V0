using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tyuiu.BelykhD.Task1.V0
{
    public partial class Form1 : Form
    {
        readonly string pathDB = "DB.csv";
        public Form1()
        {
            InitializeComponent();
            LoadCSV(pathDB);
        }


        private void LoadCSV(string pathDB)
        {
            foreach (var line in File.ReadLines(pathDB).Skip(1))
            {
                dataGridView1_Table.Rows.Add(line.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries));
            }

        }
        private void SaveCSV()
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Хотите сохранить данные перед закрытием?", "Сохранение данных", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SaveCSV();
            }
        }
    }
}
