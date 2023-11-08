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
    public partial class Oggetto_Carrello : UserControl // Concetto di ereditarietà tra la classe Oggetto_Carrello e lo UserControl
    {

		public C_Prodotto pr { get; set; } // Proprietà per rappresentare il prodotto associato a questo oggetto carrello

		public Oggetto_Carrello(C_Prodotto pr, Image logo = null) // Costruttore
        {
			// Varie proprietà
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

		// Imposto la quantità dell'oggetto
		public string Quantita
		{
			get { return lblQuantita.Text; }
			set
			{
				lblQuantita.Text = value;
			}
		}

		// Ottengo il prezzo dell'oggetto
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
			// Quando l'utente preme il tasto per aggiungere l'oggetto lo incremento
			pr.Quantita++;
			aggiorna();
		}

        private void pcbRimuovi_Click(object sender, EventArgs e)
        {
			// Rimuovo il prodotto dall'elenco dei prodotti e l'oggetto carrello
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

		// Metodo per aggiornare l'interfaccia
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
