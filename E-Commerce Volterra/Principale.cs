using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce_Volterra
{
    public partial class Principale : Form
    {

        public static List<C_Prodotto> prodotti = new List<C_Prodotto>();

        public Principale()
        {
            InitializeComponent();
        }


        private void bunifuButton6_Click(object sender, EventArgs e)
        {

        }


        private void pcbInstagram_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/volterraelia/";

            // Lo URL viene aperto in un browser web
            System.Diagnostics.Process.Start(url);
        }

        private void pcbFacebook_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/istitutovolterraelia/";

            System.Diagnostics.Process.Start(url);
        }

        private void pcbYoutube_Click (object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/@istitutovolterraelia";

            System.Diagnostics.Process.Start(url);
        }

        private void btnMaglie_Click(object sender, EventArgs e)
        {
            // L'utente viene portato nel Form delle Maglie
            new Maglie().Show();
            this.Hide();

        }

        private void btnPantaloni_Click(object sender, EventArgs e)
        {
            // L'utente viene portato nel Form dei Pantaloni
            new Pantaloni().Show();
            this.Hide();
        }

        private void btnScarpeP_Click(object sender, EventArgs e)
        {
            // L'utente viene portato nel Form delle Scarpe
            new Scarpe().Show();
            this.Hide();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Implemento la barra di ricerca

            // Dichiaro la stringa da cercare
            string stringa = bunifuTextBox1.Text.ToLower();

            foreach (Prodotto prodotto in flowLayout.Controls)
            {
                // Per ogni prodotto nel flowLayout controllo se trova la stringa

                if (prodotto.Nome.ToLower().Contains(stringa))
                {
                    prodotto.Visible = true; // Se il prodotto viene trovato è visibile nel flowLayout
                }
                else
                {
                    prodotto.Visible = false; // Se il prodotto non viene trovato non è visibile nel flowLayout
                }
            }
        }

        private void btnCarrello_Click(object sender, EventArgs e)
        {
            // Apro il form del carrello
            new Carrello().Show();
            this.Hide();
        }
    }
}
