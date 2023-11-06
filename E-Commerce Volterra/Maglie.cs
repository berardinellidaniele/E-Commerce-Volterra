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
            //
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

            foreach (Prodotto prodotto in flowLayout.Controls)
            {
                if (prodotto.Nome.ToLower().Contains(stringa))
                {
                    prodotto.Visible = true;
                }
                else
                {
                    prodotto.Visible = false;
                }
            }
        }

        private void prodotto18_Click(object sender, EventArgs e)
        {

        }

        private void flowLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
