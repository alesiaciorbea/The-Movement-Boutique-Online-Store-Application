using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Magazin
{
    public partial class LoginForm : Form
    {
        // String de conexiune la baza de date
        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Magazin.mdf;Integrated Security=True";
        private int contor = 0;

        // Constructor pentru inițializarea formularului de login
        public LoginForm()
        {
            InitializeComponent();
            // Ascunde parola în câmpul de input
            txtParola.PasswordChar = '•';
        }

        // Eveniment pentru schimbarea vizibilității parolei
        private void chkParola_CheckedChanged(object sender, EventArgs e)
        {
            // Dacă checkbox-ul este bifat, parola va fi vizibilă
            if (chkParola.Checked)
                txtParola.PasswordChar = '\0';  // Afișează parola
            else
                txtParola.PasswordChar = '•';  // Ascunde parola
            
        }

        // Evenimentul pentru butonul de login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Citește valorile introduse de utilizator
            string nume = txtNume.Text;
            string email = txtEmail.Text;
            string parola = txtParola.Text;

            // Verifică dacă toate câmpurile sunt completate
            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(parola))
            {
                MessageBox.Show("Vă rugăm să completați toate câmpurile!");
                return; // Oprește execuția dacă un câmp este gol
            }   

            // Crează conexiunea la baza de date
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            // Interogare SQL pentru a verifica existența utilizatorului
            string query = "SELECT * FROM Utilizatori WHERE Nume = @Nume AND Email = @Email AND Parola = @Parola";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Nume", nume);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Parola", parola);

            SqlDataReader reader = cmd.ExecuteReader();

            // Verifică dacă utilizatorul există în baza de date
            if (reader.Read())
            {
                string mesaj = "";
                if (!nume.All(char.IsUpper))
                    mesaj += "- Numele nu este scris cu litere mari \n";

                foreach (char caracter in email)
                    if (char.IsUpper(caracter))
                    {
                        mesaj += "- Emailul nu este scris cu litere mici \n";
                        break;
                    }

                if (!parola.All(char.IsLower))
                    mesaj += "- Parola nu este scrisă cu litere mici \n";

                if (mesaj != "")
                {
                    MessageBox.Show("S-au găsit urmatoarele erori: \n" + mesaj);
                    return;
                }

                string rol = reader["Rol"].ToString();


                // Dacă rolul este admin, deschide formularul admin
                if (rol == "admin")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                }
                // Dacă rolul este client, deschide formularul client
                else if (rol == "client")
                {
                    string utilizator = txtNume.Text;
                    ClientForm clientForm = new ClientForm(utilizator, contor);
                    clientForm.Show();
                    this.Hide();
                }
            }
            else
            {
                // Dacă nu există utilizatorul, afișează un mesaj de eroare
                MessageBox.Show("Date introduse incorect!");
            }

            // Închide conexiunea și reader-ul
            reader.Close();
            conn.Close();

            conn.Dispose();
            cmd.Dispose();
        }
        private void txtNume_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                // Mută focusul pe butonul de login
                txtEmail.Focus();
            }
        }
        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                // Mută focusul pe câmpul de parolă
                txtParola.Focus();
            }
        }

        // Eveniment pentru tastarea Enter în câmpul de parolă
        private void txtParola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                // Mută focusul pe butonul de login
                btnLogin.Focus();
            }
        }

        private void chkParola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                // Mută focusul pe butonul de login
                btnLogin.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
