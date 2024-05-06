using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Tyuiu.BelykhD.Task1.V0
{

    public partial class Authorization : Form
    {
        private readonly OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Museum.mdb");
        public Authorization()
        {
            InitializeComponent();
            conn.Open();
        }

        private void Button_SignIn_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Users;", conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["login"].ToString() == textBox_login.Text)
                {
                    if (reader["password"].ToString() == maskedTextBox_pass.Text)
                    {
                        Hide();
                        Main main = new Main(this);
                        main.Show();
                        reader.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Password Invalid.");
                        reader.Close();
                        return;
                    }
                }
            }
            MessageBox.Show("The user was not found.");
            reader.Close();

        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
