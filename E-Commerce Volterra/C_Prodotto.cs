using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Volterra
{
    public class C_Prodotto
    {
        public Image Immagine { get; set; } 
        public string Nome { get; set; }
        public double Prezzo { get; set; }
        public int Quantita { get; set;}

        public C_Prodotto(Image immagine, string Nome, double Prezzo, int Quantita = 1)
        {
            this.Immagine = immagine;
            this.Nome = Nome;
            this.Prezzo = Prezzo;
            this.Quantita = Quantita;
        }

    }
}
