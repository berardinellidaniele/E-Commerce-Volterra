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
            string prezzoString = lblPrezzo.Text.Replace("€", "").Replace(",", ".");
            string[] prezzoParti = prezzoString.Split('.');

            if (prezzoParti.Length == 2 && int.TryParse(prezzoParti[0], out int euro) && int.TryParse(prezzoParti[1], out int centesimi))
            {
                int prezzoTotaleCentesimi = euro * 100 + centesimi;

                double prezzoTotale = prezzoTotaleCentesimi / 100.0;

                Principale.prodotti.Add(new C_Prodotto(this.Immagine, lblNome.Text, prezzoTotale));
            }
            else
            {
                Console.WriteLine("Formato prezzo non valido");
            }
        }
    }
}


