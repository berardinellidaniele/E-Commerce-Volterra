using System;
using System.IO;
using System.Windows.Forms;

namespace E_Commerce_Volterra
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        // Dichiaro un metodo per cancellare tutto il contenuto delle textbox presenti nel form.
        private void ClearAll()
        {
            txbemailregister.Clear();
            txbPassword.Clear();
            txbConfermapassword.Clear();
        }

        private void btnClearregister_Click(object sender, EventArgs e)
        {
            // Quando l'utente preme il bottone "Clear" richiamo il metodo indicato sopra.
            ClearAll();
        }



        private void cmbPasswordregister_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica se la combobox è spuntata per visualizzare la password
            if (cmbPasswordregister.Checked) 
            {
                // Se la combobox è spuntata, la proprietà PasswordChar viene disabilitata e la password è nuovamente visibile
                txbPassword.PasswordChar = '\0';
                txbConfermapassword.PasswordChar = '\0';
            }
            else
            {
                // Se la combobox non è spuntata, la proprietà PasswordChar rimane abilitata e la password continua ad essere nascosta.
                txbPassword.PasswordChar = '*';
                txbConfermapassword.PasswordChar = '*';
            }
        }

        private void lblvailogin_Click(object sender, EventArgs e)
        {
            // L'utente va al form del login
            new Login().Show();
            this.Hide();
        }

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            string username = txbemailregister.Text;
            string password = txbPassword.Text;
            string confermapassword = txbConfermapassword.Text;

            // Controllo se una delle 3 textbox indicate sopra è vuota o null utilizzando il metodo IsNullOrEmpty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confermapassword))
            {
                MessageBox.Show("Compila tutti i campi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Controllo se le password inserite dall'utente sono uguali
            if (txbPassword.Text != txbConfermapassword.Text)
            {
                MessageBox.Show("Le password non corrispondono, riprova", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
                return;
            }

            try
            {
                // Viene aperto un file in modalità lettura
                using (StreamReader sr = new StreamReader("credenziali.txt"))
                {
                    string riga;
                    // Leggo tutte le righe del file
                    while ((riga = sr.ReadLine()) != null)
                    {
                        // Controllo se la riga contiene lo username inserito dall'utente
                        if (riga.Contains($"Username: {username}"))
                        {
                            MessageBox.Show("L'utente è già esistente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearAll();
                            return;
                        }
                    }
                }

                // Se l'utente non è presente nel file creo un nuovo oggetto Utente
                Utente nuovoutente = new Utente(username, password);

                MessageBox.Show("Registrazione completata con successo", "Successo", MessageBoxButtons.OK);

                // Apro il file credenziali.txt dove aggiungo lo username e la password
                using (StreamWriter sw = new StreamWriter("credenziali.txt", true))
                {
                    sw.WriteLine($"Username: {username}, Password: {password}");
                }

                new Login().Show();
                this.Hide();
                ClearAll();
            }
            catch (ArgumentException ex)
            {
                // Se viene generata un'eccezione mostro un messaggio di errore
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
            }
        }
    }
}
