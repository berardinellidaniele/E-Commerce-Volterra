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
    public partial class Maglie : Form
    {
        public Maglie()
        {
            InitializeComponent();
        }

        private void btnHomeM_Click(object sender, EventArgs e)
        {
            new Principale().Show();
            this.Hide();
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {

        }

        private void btnPantaloniM_Click(object sender, EventArgs e)
        {
            // L'utente viene portato nel Form dei Pantaloni
            new Pantaloni().Show();
            this.Hide();
        }

        private void btnScarpeM_Click(object sender, EventArgs e)
        {
            // L'utente viene portato nel Form delle Scarpe
            new Scarpe().Show();
            this.Hide();
        }

        private void pcbInstagramM_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/volterraelia/";

            // Lo URL viene aperto in un browser web
            System.Diagnostics.Process.Start(url);
        }

        private void pcbFacebookM_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/istitutovolterraelia/";

            System.Diagnostics.Process.Start(url);
        }

        private void pcbYouTubeM_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/@istitutovolterraelia";

            System.Diagnostics.Process.Start(url);
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            string stringa = bunifuTextBox1.Text.ToLower();

            // Per ogni prodotto nel flowLayout controllo se trova la stringa

            foreach (Prodotto prodotto in flowLayout.Controls)
            {
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

        private void btnCarrelloM_Click(object sender, EventArgs e)
        {
            new Carrello().Show();
            this.Hide();
        }
    }
}
