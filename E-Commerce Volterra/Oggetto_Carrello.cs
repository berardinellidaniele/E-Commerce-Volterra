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
    public partial class Oggetto_Carrello : UserControl
    {

		public C_Prodotto pr { get; set; }

		public Oggetto_Carrello(C_Prodotto pr, Image logo = null) 
        {
            InitializeComponent();
			this.pr = pr;
			this.Immagine = logo;
			this.Nome = pr.Nome;
			this.Quantita = pr.Quantita.ToString();
			this.Cifra = pr.Prezzo.ToString();
        }

		public Image Immagine
		{
			get
			{
				return pcbIcon.Image;
			}

			set
			{
				pcbIcon.Image = value;
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

		public string Quantita
		{
			get { return lblQuantita.Text; }
			set
			{
				lblQuantita.Text = value;
			}
		}

		public string Cifra
		{
			get
			{
				return lblCifra.Text;
			}
			set
			{
				lblCifra.Text = value;
			}
		}

        private void pcbAggiungi_Click(object sender, EventArgs e)
        {
			pr.Quantita++;
			aggiorna();
		}

        private void pcbRimuovi_Click(object sender, EventArgs e)
        {
			for (int i = 0; i < Principale.prodotti.Count; i++)
			{
				if (Principale.prodotti[i].Nome == this.Nome)
				{
					Principale.prodotti.RemoveAt(i);
					Carrello.Elementi_Carrello.RemoveAt(i);
					break;
				}
			}
			this.Parent.Controls.Remove(this);
			aggiorna();
		}

		private void aggiorna()
		{
			new Carrello().Show();
			Carrello carrello = Application.OpenForms.OfType<Carrello>().FirstOrDefault();
			carrello?.Close();
		}

        private void lblQuantita_Click(object sender, EventArgs e)
        {

        }
    }
}
