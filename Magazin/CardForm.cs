using System;
using System.Linq;
using System.Windows.Forms;

namespace Magazin
{
    public partial class CardForm : Form
    {
        public CardForm()
        {
            InitializeComponent();
        }

        private void btnPlata_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNumar.Text) || string.IsNullOrEmpty(txtNume.Text) || string.IsNullOrEmpty(txtLuna.Text) ||
                string.IsNullOrEmpty(txtAn.Text) || string.IsNullOrEmpty(txtCod.Text))
            {
                MessageBox.Show("Completează toate câmpurile!");
                return;
            }

            if (txtNumar.Text.All(char.IsLetter) || txtNume.Text.All(char.IsDigit) || txtLuna.Text.All(char.IsLetter) ||
                txtAn.Text.All(char.IsLetter) || txtCod.Text.All(char.IsLetter) || txtNumar.Text.Length != 16 ||
                int.Parse(txtLuna.Text) < 1 || int.Parse(txtLuna.Text) > 12 ||  int.Parse(txtAn.Text) < 2025 || 
                int.Parse(txtCod.Text) < 100 || int.Parse(txtCod.Text) > 999)
            {
                MessageBox.Show("Date introduse greșit");
                return;
            }

            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Plată efectuată cu succes!");
            this.Close();

        }
            
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtNumar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                txtNume.Focus();
            }
        }

        private void txtNume_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                txtLuna.Focus();
            }
        }

        private void txtLuna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                txtAn.Focus();
            }
        }

        private void txtAn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                txtCod.Focus();
            }
        }

        private void txtCod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                btnPlata.Focus();
            }
        }
    }
}
