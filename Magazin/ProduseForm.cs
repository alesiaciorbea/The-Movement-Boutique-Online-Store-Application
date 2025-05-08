using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Magazin
{
    public partial class ProduseForm : Form
    {
        private int cnt;
        private string numeUtilizator;
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Magazin.mdf;Integrated Security=True";

        public ProduseForm(string categorie, string utilizator, int contor)
        {
            InitializeComponent();
            numeUtilizator = utilizator;
            cnt = contor;
            if (cnt > 0) cosToolStripMenuItem.Text = "Coș (" + cnt + ")";
            IncarcaProduseClient(categorie);
        }

        private void IncarcaProduseClient(string categorie)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM Produse WHERE CATEGORIE = @Categorie ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Categorie", categorie);

            SqlDataReader reader = cmd.ExecuteReader();

            flowLayoutProduse.Controls.Clear(); // Curăță panelul

            while (reader.Read())
            {
                // Creează un panel pentru fiecare produs
                Panel panouProdus = new Panel();
                panouProdus.Width = 300;
                panouProdus.Height = 400;
                panouProdus.Margin = new Padding(10);

                // Creează PictureBox pentru imagine
                PictureBox poza = new PictureBox();
                poza.Width = 280;
                poza.Height = 250;
                poza.SizeMode = PictureBoxSizeMode.StretchImage;
                string calePoza = Path.Combine(Application.StartupPath, "produse", reader["IMAGINE"].ToString());
                poza.Image = Image.FromFile(calePoza);



                // Label pentru denumire
                Label lblDenumire = new Label();
                lblDenumire.Text = reader["DENUMIRE"].ToString();
                lblDenumire.Top = poza.Bottom + 2;
                lblDenumire.Width = 280;
                lblDenumire.Height = 30;
                lblDenumire.Font = new Font("Palatino Linotype", 16);
                lblDenumire.TextAlign = ContentAlignment.MiddleCenter;

                // Label pentru marime
                Label lblMarime = new Label();
                lblMarime.Text = "Mărimea: " + reader["MĂRIME"].ToString();
                lblMarime.Top = lblDenumire.Bottom;
                lblMarime.Width = 280;
                lblMarime.Font = new Font("Palatino Linotype", 12);
                lblMarime.TextAlign = ContentAlignment.MiddleCenter;

                // Label pentru preț
                Label lblPret = new Label();
                lblPret.Text = "Preț: " + reader["PREȚ"].ToString() + " lei";
                lblPret.Top = lblMarime.Bottom;
                lblPret.Width = 280;
                lblPret.Font = new Font("Palatino Linotype", 14, FontStyle.Bold);
                lblPret.TextAlign = ContentAlignment.MiddleCenter;

                //buton pentru adaugare in cos
                Button buton = new Button();
                buton.Top = lblPret.Bottom + 5;
                buton.Width = 280;
                buton.Height = 50;
                buton.Font = new Font("Palatino Linotype", 16, FontStyle.Bold);
                buton.TextAlign = ContentAlignment.MiddleCenter;
                buton.Cursor = Cursors.Hand;

                bool esteRezervat = (bool)reader["REZERVAT"];
                buton.Enabled = !esteRezervat;
                if (!esteRezervat)
                    buton.Text = "Adaugă în coș";
                else
                    buton.Text = "Rezervat";

                buton.Tag = new Produs
                {
                    Id = int.Parse(reader["Id"].ToString()),
                    Denumire = reader["DENUMIRE"].ToString(),
                    Marime = reader["MĂRIME"].ToString(),
                    Pret = float.Parse(reader["PREȚ"].ToString()),
                    Imagine = reader["IMAGINE"].ToString(),
                    Rezervat = esteRezervat
                };
                buton.Click += buton_Click;

                // Adaugă în panou
                panouProdus.Controls.Add(poza);
                panouProdus.Controls.Add(lblDenumire);
                panouProdus.Controls.Add(lblMarime);
                panouProdus.Controls.Add(lblPret);
                panouProdus.Controls.Add(buton);

                // Adaugă în FlowLayoutPanel
                flowLayoutProduse.Controls.Add(panouProdus);
            }

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
        }

        private void buton_Click(object sender, EventArgs e)
        {
            Button buton = sender as Button;

            if (buton.Enabled && buton != null && buton.Tag != null)
            {
                // Extragem obiectul Produs din Tag
                Produs produs = buton.Tag as Produs;

                if (produs != null)
                {
                    // Adăugăm produsul în coș
                    CosCumparaturi.Produse.Add(produs);

                    SqlConnection conn = new SqlConnection(connStr);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE Produse SET REZERVAT = 1 WHERE ID = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", produs.Id);
                    cmd.ExecuteNonQuery();

                    buton.Enabled = false;
                    buton.Text = "Rezervat";

                    // Afișează mesaj
                    MesajForm mesajForm = new MesajForm(" Produs adăugat în coș", produs.Imagine);
                    mesajForm.ShowDialog();

                    cnt++;
                    cosToolStripMenuItem.Text = "Coș (" + cnt + ")";

                    conn.Close();
                    conn.Dispose();
                    cmd.Dispose();
                }
            }
        }

        public class Produs
        {
            public int Id { get; set; }
            public string Denumire { get; set; }
            public float Pret { get; set; }
            public string Marime { get; set; }
            public string Imagine { get; set; }

            public bool Rezervat { get; set; }
        }

        public static class CosCumparaturi
        { 
            public static List<Produs> Produse = new List<Produs>();
        }

        private void acasăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm clientform = new ClientForm(numeUtilizator, cnt);
            clientform.Show();
            this.Close();
        }

        private void coșToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CosForm cosform = new CosForm(numeUtilizator, cnt);
            cosform.Show();
            this.Close();
        }
     
        private void pantofiFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProduseForm produseForm = new ProduseForm("Încălțăminte femei", numeUtilizator, cnt);
            produseForm.Show();
            this.Hide();
        }

        private void pantofiBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProduseForm produseForm = new ProduseForm("Încălțăminte bărbați", numeUtilizator, cnt);
            produseForm.Show();
            this.Hide();
        }

       
        private void costumeFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             ProduseForm produseForm = new ProduseForm("Îmbrăcăminte femei", numeUtilizator, cnt);
             produseForm.Show();
            this.Hide();
        }

        private void costumeBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProduseForm produseForm = new ProduseForm("Îmbrăcăminte bărbați", numeUtilizator, cnt);
            produseForm.Show();
            this.Hide();
        }

    }
}
