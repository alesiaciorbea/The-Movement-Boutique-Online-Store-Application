using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazin;
using static Magazin.ProduseForm;

namespace Magazin
{
    public partial class ClientForm : Form
    {
        private int cnt;
        private string numeUtilizator;
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Magazin.mdf;Integrated Security=True";

        public ClientForm(string utilizator, int contor)
        {
            InitializeComponent();
            numeUtilizator = utilizator;
            cnt = contor;
            if (cnt > 0) cosToolStripMenuItem.Text = "Coș (" + cnt + ")";

            // Centerizează label-urile pe formular
            lblSalut.Text = "BUN VENIT  " + utilizator + "!";
            lblSalut.Left = (this.ClientSize.Width - lblSalut.Width) / 2;

            lblTitlu.Text = "BESTSELLERS && NOUTĂȚI";
            lblTitlu.Left = (this.ClientSize.Width - lblTitlu.Width) / 2;
        }

        // Evenimente pentru a deschide formularul de produse pentru o anumită categorie
        private void pantofiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProduseForm produseForm = new ProduseForm("Încălțăminte femei", numeUtilizator, cnt);
            produseForm.Show();
            this.Hide();
        }

        private void costumeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProduseForm produseForm = new ProduseForm("Îmbrăcăminte femei", numeUtilizator, cnt);
            produseForm.Show();
            this.Hide();
        }

        private void pantofiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProduseForm produseForm = new ProduseForm("Încălțăminte bărbați", numeUtilizator, cnt);
            produseForm.Show();
            this.Hide();
        }

        private void costumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProduseForm produseForm = new ProduseForm("Îmbrăcăminte bărbați", numeUtilizator, cnt);
            produseForm.Show();
            this.Hide();
        }

        // Eveniment pentru a deschide formularul de informare
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm(numeUtilizator);
            infoForm.Show();
            this.Hide();
        }

        // Eveniment pentru a deschide formularul de coș de cumpărături
        private void coșToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CosForm cosForm = new CosForm(numeUtilizator, cnt);
            cosForm.Show();
            this.Hide();
        }


        private void deconectareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Sunteți sigur ca doriți să vă deconectați?", "Deconectare", MessageBoxButtons.YesNo);

            if (rezultat == DialogResult.No)  return;

            foreach (var produs in CosCumparaturi.Produse)
    {
                // Actualizează starea produsului în baza de date
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Produse SET REZERVAT = 0 WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", produs.Id);
                cmd.ExecuteNonQuery();

                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }

            // Curăță lista de produse din coș
            CosCumparaturi.Produse.Clear();

            // Deschide formularul de login
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        // Deschide formularul produselor după categoria dată
        private void pbFPantofi_Click(object sender, EventArgs e)
        {
            ProduseForm produseForm = new ProduseForm("Încălțăminte femei", numeUtilizator, cnt);
            produseForm.Show();
            this.Hide();
        }
        
        private void pbFCostum_Click(object sender, EventArgs e)
        {
            ProduseForm produseForm = new ProduseForm("Îmbrăcăminte femei", numeUtilizator, cnt);
            produseForm.Show();
            this.Hide();
        }

        private void pbBCostum_Click(object sender, EventArgs e)
        {
            ProduseForm produseForm = new ProduseForm("Îmbrăcăminte bărbați", numeUtilizator, cnt);
            produseForm.Show();
            this.Hide();
        }

        private void pbBPantofi_Click(object sender, EventArgs e)
        {
            ProduseForm produseForm = new ProduseForm("Încălțăminte bărbați", numeUtilizator, cnt);
            produseForm.Show();
            this.Hide();
        }
        
    }
}
