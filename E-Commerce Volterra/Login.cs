using System;
using System.IO;
using System.Windows.Forms;

namespace E_Commerce_Volterra
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Dichiaro un metodo per cancellare tutto il contenuto delle textbox presenti nel form.
        private void ClearAll()
        {
            txbusernameL.Clear();
            txbPasswordL.Clear();
        }

        private void lblCreaunaccount_Click(object sender, EventArgs e)
        {
            // L'utente va al form del register
            new Register().Show();
            this.Close();
        }

        private void btnClearL_Click(object sender, EventArgs e)
        {
            // Quando l'utente preme il bottone "Clear" richiamo il metodo indicato sopra.
            ClearAll();
        }

        private void cmbPasswordL_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica se la combobox è spuntata per visualizzare la password
            if (cmbPasswordL.Checked)
            {
                // Se la combobox è spuntata, la proprietà PasswordChar viene disabilitata e la password è nuovamente visibile
                txbPasswordL.PasswordChar = '\0';
            }
            else
            {
                // Se la combobox non è spuntata, la proprietà PasswordChar rimane abilitata e la password continua ad essere nascosta.
                txbPasswordL.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbusernameL.Text;
            string password = txbPasswordL.Text;

            // Controllo se una delle 2 textbox indicate sopra è vuota o null utilizzando il metodo IsNullOrEmpty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Compila tutti i campi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Dichiaro una variabile bool per vedere se le credenziali sono valide
            bool valide = false;

            // Viene aperto un file in modalità lettura
            using (StreamReader sr = new StreamReader("credenziali.txt"))
            {
                string riga;
                // Leggo tutte le righe del file.

                while ((riga = sr.ReadLine()) != null)
                {
                    if (riga.Contains($"Username: {username}") && riga.Contains($"Password: {password}"))
                    {
                        // Se lo username e la password sono presenti su credenziali.txt le credenziali sono valide.
                        valide = true;
                        break;
                    }
                }
            }

            // Controllo il valore di valide
            if (valide == true)
            {
                MessageBox.Show("Accesso eseguito con successo!", "Successo", MessageBoxButtons.OK);
                new Principale().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenziali non valide, riprova", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
            }
        }
    }
}
