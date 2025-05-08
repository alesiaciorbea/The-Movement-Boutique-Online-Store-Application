using System;
using System.Windows.Forms;

namespace Magazin
{
    public partial class InfoForm : Form
    {
        private int cnt;
        private string numeUtilizator;
        public InfoForm(string utilizator)
        {
            InitializeComponent();
            numeUtilizator = utilizator;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(numeUtilizator, cnt);
            clientForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
