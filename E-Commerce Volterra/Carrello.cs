using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Management;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce_Volterra
{
    public partial class Carrello : Form
    {

        public static List<Oggetto_Carrello> Elementi_Carrello = new List<Oggetto_Carrello>(); 

        public Carrello()
        {
            InitializeComponent();
        }

        private void pcbHomeC_Click(object sender, EventArgs e)
        {
            new Principale().Show();
            this.Hide();
        }

        private void Carrello_Load(object sender, EventArgs e)
        {
            Carrello.Elementi_Carrello.Clear();

            foreach(var prodotto in Principale.prodotti)
            {
                Elementi_Carrello.Add(new Oggetto_Carrello(prodotto));
            }

			foreach (var ordine in Elementi_Carrello)
			{
				flowLayoutPanel1.Controls.Add(ordine);
			}

			if (Elementi_Carrello.Count > 0)
			{
				btnPaga.Enabled = true;
			}

            lblPrezzo.Text = $"${CalcolaPrezzo()}";

            

		}

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Principale.prodotti.Clear();
            new Carrello().Show();
            this.Hide();
        }

        private void btnPaga_Click(object sender, EventArgs e)
        {
            if (Elementi_Carrello.Count > 0)
            {
                MessageBox.Show("Pagato");
                Principale.prodotti.Clear();
                new Principale().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nessun prodotto nel carrello", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new Principale().Show();
                this.Hide();
            }
        }

        private string CalcolaPrezzo()
        {
            double prezzototale = 0;

            foreach(var oggettoCarrello in Elementi_Carrello)
            {
                prezzototale += oggettoCarrello.pr.Prezzo * Convert.ToDouble(oggettoCarrello.Quantita);
            }

            return prezzototale.ToString();
        }
    }
}
