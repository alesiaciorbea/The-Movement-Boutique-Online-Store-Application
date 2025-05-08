using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Magazin
{
    public partial class AdminForm : Form
    {
        // Variabile pentru gestionarea imaginii și conexiunii la baza de date
        private string caleImagine;
        private bool ok = false;
        private string imagineInitiala = Path.Combine(Application.StartupPath, "resurse", "logo rotund.png");

        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Magazin.mdf;Integrated Security=True";

        public AdminForm()
        {
            InitializeComponent();

            // Adaugă opțiuni pentru ComboBox la încărcarea formularului
            cmbCategorie.Items.Add("Selectează");
            cmbCategorie.Items.Add("Îmbrăcăminte femei");
            cmbCategorie.Items.Add("Încălțăminte femei");
            cmbCategorie.Items.Add("Îmbrăcăminte bărbați");
            cmbCategorie.Items.Add("Încălțăminte bărbați");

            // Setează valoarea implicită pentru ComboBox
            cmbCategorie.SelectedIndex = 0;

            IncarcaProduse();
            IncarcaComenzi();
        }

        public void IncarcaComenzi()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM Comenzi";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable tabel = new DataTable();
            tabel.Load(reader);

            dgvComenzi.DataSource = tabel;

            reader.Close();
            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            dgvComenzi.ColumnHeadersDefaultCellStyle.Font = new Font("Palatino Linotype", 12, FontStyle.Bold);
            dgvComenzi.DefaultCellStyle.Font = new Font("Palatino Linotype", 10);
            dgvComenzi.Columns["ADRESĂ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void IncarcaProduse()
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM Produse";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable tabela = new DataTable();
            tabela.Load(reader);

            dgvProduse.DataSource = tabela;

            reader.Close();
            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            dgvProduse.ColumnHeadersDefaultCellStyle.Font = new Font("Palatino Linotype", 12, FontStyle.Bold);
            dgvProduse.DefaultCellStyle.Font = new Font("Palatino Linotype", 10);
            dgvProduse.Columns["IMAGINE"].Visible = false;
            dgvProduse.Columns["REZERVAT"].Visible = false;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string denumireProdus = txtDenumire.Text;
            string categorieProdus = cmbCategorie.Text;
            string marimeProdus = txtMarime.Text;
            float pretProdus = float.Parse(txtPret.Text);
            if (!ok)
            {
                if (pbImagine.ImageLocation != null)
                    caleImagine = Path.GetFileName(pbImagine.ImageLocation);
                else
                    caleImagine = "";
            }

            // Verificăm dacă câmpurile sunt completate corect
            if (string.IsNullOrEmpty(denumireProdus) || string.IsNullOrEmpty(categorieProdus) || 
                string.IsNullOrEmpty(caleImagine) || cmbCategorie.SelectedIndex == 0 || pretProdus <= 0)
            {
                MessageBox.Show("Completează toate câmpurile corect!");
                return;
            }

            SqlConnection connVerificare = new SqlConnection(connStr);
            connVerificare.Open();

            string verificare = "SELECT COUNT(*) FROM Produse WHERE Denumire = @Denumire " +
                "AND Categorie = @Categorie AND Mărime = @Marime AND Preț = @Pret AND IMAGINE = @Imagine";
            SqlCommand cmdVerificare = new SqlCommand(verificare, connVerificare);
            cmdVerificare.Parameters.AddWithValue("@Denumire", denumireProdus);
            cmdVerificare.Parameters.AddWithValue("@Categorie", categorieProdus);
            cmdVerificare.Parameters.AddWithValue("@Marime", marimeProdus);
            cmdVerificare.Parameters.AddWithValue("@Pret", pretProdus);
            cmdVerificare.Parameters.AddWithValue("@Imagine", caleImagine);

            cmdVerificare.ExecuteNonQuery();
            int count = (int)cmdVerificare.ExecuteScalar();

            connVerificare.Close();
            connVerificare.Dispose();
            cmdVerificare.Dispose();

            if (count == 0)
            {
                // Conexiune și comandă pentru adăugarea produsului în baza de date
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                string query = "INSERT INTO Produse (DENUMIRE, CATEGORIE, MĂRIME, PREȚ, IMAGINE, REZERVAT) " +
                    "VALUES (@Denumire, @Categorie, @Mărime, @Preț, @Imagine, @Rezervat)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Denumire", denumireProdus);
                cmd.Parameters.AddWithValue("@Categorie", categorieProdus);
                cmd.Parameters.AddWithValue("@Mărime", marimeProdus);
                cmd.Parameters.AddWithValue("@Preț", pretProdus);
                cmd.Parameters.AddWithValue("@Imagine", caleImagine);
                cmd.Parameters.AddWithValue("@Rezervat", false);

                cmd.ExecuteNonQuery();

                conn.Close();
                conn.Dispose();
                cmd.Dispose();

                // Reîmprospătează lista de produse
                IncarcaProduse();

                // Resetare câmpuri
                ok = false;
                txtDenumire.Text = "";
                txtMarime.Text = "";
                txtPret.Text = ""; 
                pbImagine.Image = Image.FromFile(imagineInitiala);
                cmbCategorie.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Produsul există deja în baza de date!");
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if(dgvProduse.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectează un produs pentru a-l modifica!");
                return;
            }

            // Preluăm datele din câmpurile de text
            string denumireProdus = txtDenumire.Text;
            string categorieProdus = cmbCategorie.Text;
            string marimeProdus = txtMarime.Text;
            float pretProdus = float.Parse(txtPret.Text);
            if (!ok)
            {
                if (pbImagine.ImageLocation != null)
                    caleImagine = Path.GetFileName(pbImagine.ImageLocation);
                else
                    caleImagine = "";
            }

            // Verificăm dacă sunt completate toate câmpurile
            if (string.IsNullOrEmpty(denumireProdus) || string.IsNullOrEmpty(categorieProdus) || 
                string.IsNullOrEmpty(caleImagine) || cmbCategorie.SelectedIndex == 0 || pretProdus <= 0)
            {
                MessageBox.Show("Completează toate câmpurile corect!");
                return;
            }

            // Preluăm ID-ul produsului selectat din DataGridView
            int idProdus = Convert.ToInt32(dgvProduse.SelectedRows[0].Cells["Id"].Value);

            // Conectăm la baza de date și actualizăm produsul
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "UPDATE Produse SET DENUMIRE = @Denumire, CATEGORIE = @Categorie, " +
                "MĂRIME = @Mărime, PREȚ = @Preț, IMAGINE = @Imagine WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", idProdus);
            cmd.Parameters.AddWithValue("@Denumire", denumireProdus);
            cmd.Parameters.AddWithValue("@Categorie", categorieProdus);
            cmd.Parameters.AddWithValue("@Mărime", marimeProdus);
            cmd.Parameters.AddWithValue("@Preț", pretProdus);
            cmd.Parameters.AddWithValue("@Imagine", caleImagine);

            cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            // Reîmprospătează lista de produse
            IncarcaProduse();

            // Resetare câmpuri
            ok = false;
            txtDenumire.Text = "";
            txtMarime.Text = "";
            txtPret.Text = "";
            pbImagine.Image = Image.FromFile(imagineInitiala);
            cmbCategorie.SelectedIndex = 0;
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            // Verificăm dacă s-a selectat un produs
            if (dgvProduse.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectează un produs pentru a-l șterge!");
                return;
            }

            // Preluăm ID-ul produsului selectat
            int id = Convert.ToInt32(dgvProduse.SelectedRows[0].Cells["Id"].Value);

            // Conectăm la baza de date și ștergem produsul
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "DELETE FROM Produse WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            // Resetare câmpuri
            IncarcaProduse();
            txtDenumire.Text = "";
            txtMarime.Text = "";
            txtPret.Text = "";
            pbImagine.Image = Image.FromFile(imagineInitiala);
            cmbCategorie.SelectedIndex = 0;
        }

        // Căutare produs în baza de date
        private void txtCauta_TextChanged(object sender, EventArgs e)
        {
            string denumireProdus = txtCauta.Text;

            if (string.IsNullOrEmpty(denumireProdus))
            {
                IncarcaProduse();
                return;
            }

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string interogare = "SELECT * FROM Produse WHERE DENUMIRE LIKE @Denumire";
            SqlCommand cmd = new SqlCommand(interogare, conn);
            cmd.Parameters.AddWithValue("@Denumire", "%" + denumireProdus + "%");

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable tabel = new DataTable();
            tabel.Load(reader); // aici citim totul din reader în tabelul nostru

            dgvProduse.DataSource = tabel;

            reader.Close();
            conn.Close();
            conn.Dispose();
            cmd.Dispose();

        }

        private void btnImagine_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagini|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string numeFisier = Path.GetFileName(openFileDialog.FileName); // <-- doar numele fișierului
                string destinatieFolder = Path.Combine(Application.StartupPath, "produse");

                // Creează folderul dacă nu există
                if (!Directory.Exists(destinatieFolder))
                {
                    Directory.CreateDirectory(destinatieFolder);
                }

                // Copiază imaginea aleasă în folderul "produse"
                string destinatieComplet = Path.Combine(destinatieFolder, numeFisier);
                File.Copy(openFileDialog.FileName, destinatieComplet, true); // true = suprascrie dacă există

                caleImagine = numeFisier; // Salvăm doar numele, nu calea completă
                pbImagine.Image = Image.FromFile(destinatieComplet);
                ok = true;
            }
        }

        private void dgvProduse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtDenumire.Text = dgvProduse.Rows[e.RowIndex].Cells["DENUMIRE"].Value.ToString();
                cmbCategorie.Text = dgvProduse.Rows[e.RowIndex].Cells["CATEGORIE"].Value.ToString();
                txtMarime.Text = dgvProduse.Rows[e.RowIndex].Cells["MĂRIME"].Value.ToString();
                txtPret.Text = dgvProduse.Rows[e.RowIndex].Cells["PREȚ"].Value.ToString();

                string numeImagine = dgvProduse.Rows[e.RowIndex].Cells["IMAGINE"].Value?.ToString();
                string caleImagineCompleta = Path.Combine(Application.StartupPath, "produse", numeImagine);

                // Verifică dacă imaginea există
                if (File.Exists(caleImagineCompleta))
                {
                    pbImagine.ImageLocation = caleImagineCompleta;
                }
                else
                {
                    pbImagine.ImageLocation = ""; 
                }
            }
        }

        /// LISTA COMENZI
        private void btnFinalizare_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvComenzi.SelectedRows[0].Cells["Id"].Value);

            // Conectăm la baza de date și actualizăm produsul
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "UPDATE Comenzi SET [STATUS COMANDĂ] = 1 WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", id);

            cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            // Reîmprospătează lista de produse
            IncarcaComenzi();
        }

        private void btnStergeC_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvComenzi.SelectedRows[0].Cells["Id"].Value);

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string query = "DELETE FROM Comenzi WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            // Reîmprospătează lista de produse
            IncarcaComenzi();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
