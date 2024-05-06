using System.Windows.Forms;

namespace Tyuiu.BelykhD.Task1.V0
{
    public partial class Main : Form
    {
        private Authorization authorization;

        public Main()
        {
            InitializeComponent();
        }

        public Main(Authorization authorization)
        {
            InitializeComponent();
            this.authorization = authorization;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            authorization.Show();
        }

        private void ToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            AProgramm programm = new AProgramm();
            programm.Show();
        }
    }
}
