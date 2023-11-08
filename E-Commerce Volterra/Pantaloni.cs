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
    public partial class Pantaloni : Form
    {
        public Pantaloni()
        {
            InitializeComponent();
        }

        private void btnHomeP_Click(object sender, EventArgs e)
        {
            new Principale().Show();
            this.Hide();
        }

        private void btnMaglieP_Click(object sender, EventArgs e)
        {
            new Maglie().Show();
            this.Hide();
        }

        private void btnPantaloniP_Click(object sender, EventArgs e)
        {
            // Non apro nessun Form perchè sono già in quello dei pantaloni
        }

        private void btnScarpeP_Click(object sender, EventArgs e)
        {
            new Scarpe().Show();
            this.Hide();
        }

        private void pcbInstagramP_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/volterraelia/";

            // Lo URL viene aperto in un browser web
            System.Diagnostics.Process.Start(url);
        }

        private void pcbFacebookP_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/istitutovolterraelia/";

            System.Diagnostics.Process.Start(url);
        }

        private void pcbYouTubeP_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/@istitutovolterraelia";

            System.Diagnostics.Process.Start(url);
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            string stringa = bunifuTextBox1.Text.ToLower();

            // Per ogni prodotto nel flowLayout controllo se trova la stringa

            foreach (Prodotto prodotto in flawlayout.Controls)
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

        private void btnCarrelloP_Click(object sender, EventArgs e)
        {
            // Apro il form del carrello
            new Carrello().Show();
            this.Hide();
        }
    }
}
