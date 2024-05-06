using System;
using System.Data;
using System.Windows.Forms;

namespace Tyuiu.BelykhD.Task1.V0
{
    public partial class Order : Form
    {

        private DataTable dt;


        public Order(System.Data.DataTable DataTable)
        {
            InitializeComponent();
            this.dt = DataTable;
        }



        private void TextBox_Cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Button_CreateOrder_Click(object sender, EventArgs e)
        {

            int id = dt.Rows.Count + 1;
            string car = maskedTextBox_Car.Text.Replace(' ', '_');
            string pnone = maskedTextBox_Phone.Text;
            string master = comboBox_Master.Text;
            string service = textBox_Service.Text;
            string cost = textBox_Cost.Text;
            string data = maskedTextBox_DataComplite.Text;
            string[] order = { id.ToString(), car, pnone, master, service, cost, data };
            foreach (string s in order)
            {
                if (s.Length == 0)
                {
                    MessageBox.Show("Не все данные заполнены. Пожалуйста, заполните все поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            dt.Rows.Add(order);


        }

    }
}
