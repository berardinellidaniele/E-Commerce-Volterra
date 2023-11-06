using System.Drawing;

namespace E_Commerce_Volterra
{
    public partial class Prodotto : Bunifu.UI.WinForms.BunifuUserControl
    {
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
    }
}
