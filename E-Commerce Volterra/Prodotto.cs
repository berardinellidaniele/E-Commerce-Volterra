using System;
using System.Drawing;
using System.Windows.Forms;

namespace E_Commerce_Volterra
{
    public partial class Prodotto : Bunifu.UI.WinForms.BunifuUserControl
    {
        public int _recensioni;
        public Prodotto()
        {
            InitializeComponent();
        }

        public Image Immagine
        {
            get
            {
                return pcbProdotto.Image;
            }

            set
            {
                pcbProdotto.Image = value;
            }
        }

        public string Nome
        {
            get
            {
                return lblNome.Text;
            }

            set
            {
                lblNome.Text = value;
            }
        }

        public string Prezzo
        {
            get
            {
                return lblPrezzo.Text;
            }

            set
            {
                lblPrezzo.Text = value;
            }
        }

        public int Recensioni
        {
            get
            {
                return bunifuRecensioni.Value;
            }
            set
            {
                bunifuRecensioni.Value = value;
            }
        }

        private void pcbCarrello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prova");
        }
    }
}

