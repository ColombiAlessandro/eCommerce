using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceColombi
{
    public class Carrello
    {
        private string id;
        private Prodotto[] prodotti;
        private int contProdotti;
        private int max=100;
        public Carrello(string iD)
        {
            ID = iD;
            contProdotti = 0;
            prodotti=new Prodotto[max];
        }
        public string ID
        {
             get { return id; }
           private set { id = value; }
        }
        public Prodotto[] Prodotti
        {
            get { return prodotti; }
             set { prodotti = value; }
        }
        public void aggiungi(Prodotto prodotto)
        {
            if (prodotto != null)
            {
                Prodotti[contProdotti]=prodotto;
                contProdotti++;
            }
        }
        public Prodotto ricercaProdotto(Prodotto idProdotto)
        {
            for (int i=0; i < contProdotti; i++)
            {
                if (Prodotti[contProdotti].ID == idProdotto.ID)
                {
                    return Prodotti[contProdotti];
                }
            }
            throw new Exception("Prodotto non trovato");
        }
        public Prodotto rimuovi(Prodotto prod)
        {
            for (int i=0; i < contProdotti; i++)
            {
                if (prod.ID == Prodotti[contProdotti].ID)
                {
                    for(int j = i; j < contProdotti; j++)
                    {
                        Prodotti[contProdotti] = Prodotti[contProdotti + 1];
                    }
                    contProdotti--;
                    return prod;
                }
            }
            throw new Exception("Prodotto non trovato");
        } 
        public Prodotto[] svuotaCarrello()
        {
            Prodotto [] vecchiProdotti = new Prodotto[contProdotti];
            vecchiProdotti = Prodotti;
            Prodotti = new Prodotto[max];
            return vecchiProdotti;
        }
        public float calcolaPrezzo()
        {
            float somma = 0;
            for(int i=0; i < contProdotti; i++)
            {
                somma += Prodotti[i].Prezzo;
            }
            return somma;
        }
        
    }
}
