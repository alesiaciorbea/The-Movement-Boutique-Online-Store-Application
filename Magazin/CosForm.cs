using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Magazin.ProduseForm;

namespace Magazin
{
    public partial class CosForm : Form
    {
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Magazin.mdf;Integrated Security=True";
        private string numeUtilizator;
        private string listaproduse = "";
        private string livrare = "";
        private string plata = "";
        private float pret;
        private int cnt;
        
        public CosForm(string utilizator, int contor)
        {
            InitializeComponent();
            numeUtilizator = utilizator;
            cnt = contor;
            IncarcaLista(); // Se încarcă lista produselor în coș
        }

        private void IncarcaLista()
        {
            StergeCos(); // Se curăță tabela temporară Cos

            listaproduse = "";
            pret = 0;

            // Se parcurg produsele din lista globală și se inserează în tabela Cos
            foreach (var produs in CosCumparaturi.Produse)
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();

                string query = "INSERT INTO Cos (Denumire, Mărime, Preț) VALUES (@Denumire, @Marime, @Pret)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Denumire", produs.Denumire);
                cmd.Parameters.AddWithValue("@Marime", produs.Marime);
                cmd.Parameters.AddWithValue("@Pret", produs.Pret);

                // Se adaugă produsul în listaproduse pentru salvarea în tabela Comenzi
                if (listaproduse == "")
                    listaproduse += produs.Denumire + ", " + produs.Pret + " lei";
                else
                    listaproduse += "\n" + produs.Denumire + ", " + produs.Pret + " lei";

                pret += produs.Pret;

                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }

            lblTotal.Text = pret.ToString() + " lei"; // Se afișează totalul
            IncarcaCos(); // Se reîncarcă DataGridView-ul
        }

        private void IncarcaCos()
        {
            // Încarcă datele din tabela Cos în DataGridView
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string interogare = "SELECT * FROM Cos";
            SqlCommand cmd = new SqlCommand(interogare, conn);
            SqlDataReader query = cmd.ExecuteReader();

            DataTable tabel = new DataTable();
            tabel.Load(query);
            dgvComenzi.DataSource = tabel;

            query.Close();
            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            // Formatări pentru afișare
            dgvComenzi.ColumnHeadersDefaultCellStyle.Font = new Font("Palatino Linotype", 12, FontStyle.Bold);
            dgvComenzi.DefaultCellStyle.Font = new Font("Palatino Linotype", 10);
            dgvComenzi.Columns["Id"].Visible = false;
        }

        private void StergeCos()
        {
            // Șterge toate înregistrările din tabela temporară Cos
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Cos", conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
        }

        private void btnComana_Click(object sender, EventArgs e)
        {
            // Verifică dacă câmpurile sunt completate
            if (string.IsNullOrEmpty(txtLocalitate.Text) || string.IsNullOrEmpty(txtStrada.Text) ||
                string.IsNullOrEmpty(plata) || string.IsNullOrEmpty(livrare))
            {
                MessageBox.Show("Completează toate câmpurile!");
                return;
            }

            // Verifică dacă sunt produse în coș
            if (dgvComenzi.Rows.Count == 0 || (dgvComenzi.Rows.Count == 1 && dgvComenzi.Rows[0].IsNewRow))
            {
                MessageBox.Show("Nu există produse în coș");
                return;
            }

            // Dacă plata este cu cardul, se deschide fereastra de card
            if (plata == "Card")
            {
                CardForm cardForm = new CardForm();
                if (cardForm.ShowDialog() == DialogResult.OK)
                {
                    // Inserare comandă în baza de date
                    SqlConnection conn = new SqlConnection(connStr);
                    conn.Open();
                    string query = "INSERT INTO Comenzi (Utilizator, Produse, Adresă, Livrare, Total, Plată, Dată) " +
                        "VALUES (@Utilizator, @Produse, @Adresa, @Livrare, @Total, @Plata, @Data)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Utilizator", numeUtilizator);
                    cmd.Parameters.AddWithValue("@Produse", listaproduse);
                    cmd.Parameters.AddWithValue("@Adresa", txtLocalitate.Text + ", " + txtStrada.Text);
                    cmd.Parameters.AddWithValue("@Livrare", livrare);
                    cmd.Parameters.AddWithValue("@Total", pret);
                    cmd.Parameters.AddWithValue("@Plata", plata);
                    cmd.Parameters.AddWithValue("@Data", DateTime.Now);
                    cmd.ExecuteNonQuery();

                    // Se golește coșul
                    CosCumparaturi.Produse.Clear();
                    StergeCos();
                    IncarcaCos();

                    // Mesaj de confirmare
                    string imagine = Path.Combine(Application.StartupPath, "resurse", "Confirmare.png");
                    MesajForm mesajForm = new MesajForm("Comanda a fost finalizată cu succes!", imagine);
                    mesajForm.Show();

                    // Resetare câmpuri
                    cnt = 0;
                    listaproduse = "";
                    pret = 0;
                    txtLocalitate.Text = "";
                    txtStrada.Text = "";
                    lblTotal.Text = "";
                    chkNumerar.Checked = false;
                    chkCard.Checked = false;
                    chkStandard.Checked = false;
                    chkExpres.Checked = false;
                }
            }
            else
            {
                // Inserare comandă pentru plata numerar
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                string query = "INSERT INTO Comenzi (Utilizator, Produse, Adresă, Livrare, Total, Plată, Dată)" +
                    "VALUES (@Utilizator, @Produse, @Adresa, @Livrare, @Total, @Plata, @Data)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Utilizator", numeUtilizator);
                cmd.Parameters.AddWithValue("@Produse", listaproduse);
                cmd.Parameters.AddWithValue("@Adresa", txtLocalitate.Text + ", " + txtStrada.Text);
                cmd.Parameters.AddWithValue("@Livrare", livrare);
                cmd.Parameters.AddWithValue("@Total", pret);
                cmd.Parameters.AddWithValue("@Plata", plata);
                cmd.Parameters.AddWithValue("@Data", DateTime.Now);
                cmd.ExecuteNonQuery();

                // Se golește coșul
                CosCumparaturi.Produse.Clear();
                StergeCos();
                IncarcaCos();

                // Mesaj de confirmare
                string imagine = Path.Combine(Application.StartupPath, "resurse", "Confirmare.png");
                MesajForm mesajForm = new MesajForm("Comanda a fost finalizată cu succes!", imagine);
                mesajForm.Show();

                // Resetare câmpuri
                cnt = 0;
                listaproduse = "";
                pret = 0;
                txtLocalitate.Text = "";
                txtStrada.Text = "";
                lblTotal.Text = "";
                chkNumerar.Checked = false;
                chkCard.Checked = false;
                chkStandard.Checked = false;
                chkExpres.Checked = false;
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            // Se șterge produsul selectat din DataGridView și lista de produse
            if (dgvComenzi.SelectedRows.Count > 0)
            {
                string denumire = dgvComenzi.SelectedRows[0].Cells["Denumire"].Value.ToString();
                string marime = dgvComenzi.SelectedRows[0].Cells["Mărime"].Value.ToString();
                float pret = float.Parse(dgvComenzi.SelectedRows[0].Cells["Preț"].Value.ToString());

                // Actualizează starea produsului în baza de date
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Produse SET REZERVAT = 0" +
                        "WHERE Denumire = @Denumire AND Mărime = @Marime AND Preț = @Pret", conn);
                    cmd.Parameters.AddWithValue("@Denumire", denumire);
                    cmd.Parameters.AddWithValue("@Marime", marime);
                    cmd.Parameters.AddWithValue("@Pret", pret);
                    cmd.ExecuteNonQuery();
                }

                var produsDeSters = CosCumparaturi.Produse.FirstOrDefault(p =>
                    p.Denumire == denumire &&
                    p.Marime == marime &&
                    p.Pret == pret);

                if (produsDeSters != null)
                {
                    CosCumparaturi.Produse.Remove(produsDeSters);
                }

                IncarcaLista();
                IncarcaCos();
                GetLivrare();

                cnt--;
                pret = 0;
                listaproduse = "";
            }
            else
            {
                MessageBox.Show("Selectează un produs pentru a-l șterge!");
            }
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            // Confirmare anulare și revenire la meniul client
            DialogResult rezultat = MessageBox.Show("Sunteți sigur ca doriți să anulați comanda?", "Anulare comanda", MessageBoxButtons.YesNo);

            if (rezultat == DialogResult.Yes)
            {
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

                cnt = 0;
                CosCumparaturi.Produse.Clear();
                ClientForm clientForm = new ClientForm(numeUtilizator, cnt);
                clientForm.Show();
                this.Hide();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Revenire la meniul client și ștergerea coșului
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            SqlCommand stergeCmd = new SqlCommand("DELETE FROM Cos", con);
            stergeCmd.ExecuteNonQuery();
            con.Close();

            ClientForm clientForm = new ClientForm(numeUtilizator, cnt);
            clientForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Ieșire din aplicație
            Application.Exit();
        }

        private void GetLivrare()
        {
            // Calculează totalul în funcție de metoda de livrare
            if (chkStandard.Checked)
            {
                livrare = "Standard";
                lblTotal.Text = (pret + 15).ToString() + " lei";
            }
            else if (chkExpres.Checked)
            {
                livrare = "Expres";
                lblTotal.Text = (pret + 35).ToString() + " lei";
            }
            else
                lblTotal.Text = pret.ToString() + " lei";
        }

        private void chkStandard_CheckedChanged(object sender, EventArgs e)
        {
            // Selectare exclusivă pentru livrare Standard
            if (chkStandard.Checked)
                chkExpres.Checked = false;

            GetLivrare();
        }

        private void chkExpres_CheckedChanged(object sender, EventArgs e)
        {
            // Selectare exclusivă pentru livrare Expres
            if (chkExpres.Checked)
                chkStandard.Checked = false;

            GetLivrare();
        }

        private void chkCard_CheckedChanged(object sender, EventArgs e)
        {
            // Selectare exclusivă pentru plată cu card
            if (chkCard.Checked)
            {
                plata = "Card";
                chkNumerar.Checked = false;
            }
        }

        private void chkNumerar_CheckedChanged(object sender, EventArgs e)
        {
            // Selectare exclusivă pentru plată numerar
            if (chkNumerar.Checked)
            {
                plata = "Numerar";
                chkCard.Checked = false;
            }
        }

        private void txtLocalitate_KeyDown(object sender, KeyEventArgs e)
        {
            // Trecere la câmpul următor la apăsarea Enter
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtStrada.Focus();
            }
        }

        private void txtStrada_KeyDown(object sender, KeyEventArgs e)
        {
            // Trecere la butonul Comandă la apăsarea Enter
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnComana.Focus();
            }
        }
    }
}
