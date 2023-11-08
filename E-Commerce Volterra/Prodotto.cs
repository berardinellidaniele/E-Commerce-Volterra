using System;
using System.Drawing;
using System.Windows.Forms;

namespace E_Commerce_Volterra
{
    public partial class Prodotto : Bunifu.UI.WinForms.BunifuUserControl
    {
        // Dichiaro una variabile per gestire il valore delle recensioni
        public int _recensioni;

        public Prodotto() // Costruttore della classe prodotto
        {
            InitializeComponent();
        }

        public Image Immagine // Proprietà per gestire l'immagine del prodotto
        {
            get
            {
                return pcbProdotto.Image; // Restituisce l'immagine della PictureBox
            }

            set
            {
                pcbProdotto.Image = value; // Imposto l'immagine 
            }
        }

        public string Nome // Proprietà per gestire il nome del prodotto
        {
            get
            {
                return lblNome.Text; // Restituisce il 
            }

            set
            {
                lblNome.Text = value; // Imposto il nome
            }
        }

        public string Prezzo // Proprietà per gestire il prezzo del prodotto
        {
            get
            {
                return lblPrezzo.Text; // Restituisce il prezzo
            }

            set
            {
                lblPrezzo.Text = value; // Imposto il prezzo
            }
        }

        public int Recensioni // Proprietà per gestire le recensioni del prodotto
        {
            get
            {
                return bunifuRecensioni.Value; // Restituisce le recensioni
            }
            set
            {
                bunifuRecensioni.Value = value; // Imposto il valore delle recensioni
            }
        }

        private void pcbCarrello_Click(object sender, EventArgs e)
        {
            // Quando l'utente preme nel carrello elaboro il prezzo e lo aggiungo alla lista dei prodotti
            string prezzoString = lblPrezzo.Text.Replace("€", "").Replace(",", "."); 
            string[] prezzoParti = prezzoString.Split('.');

            // Verifico il prezzo e lo converto in centesimi
            if (prezzoParti.Length == 2 && int.TryParse(prezzoParti[0], out int euro) && int.TryParse(prezzoParti[1], out int centesimi))
            {
                int prezzoTotaleCentesimi = euro * 100 + centesimi;

                double prezzoTotale = prezzoTotaleCentesimi / 100.0;

                // Aggiungo l'oggetto C_Prodotti alla lista dei prodotti
                Principale.prodotti.Add(new C_Prodotto(this.Immagine, lblNome.Text, prezzoTotale));
            }
            else
            {
                Console.WriteLine("Formato prezzo non valido");
            }
        }
    }
}


