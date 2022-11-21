using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCommerceColombi
{
    public partial class Form1 : Form
    {
        Carrello carrello = new Carrello("IDCarrello");
        int numProdotti = 5;
        Prodotto[] prodotti=new Prodotto[5];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prodotti = new Prodotto[numProdotti];
            carrello.Prodotti = new Prodotto[100];
            prodotti[0] = new Prodotto("ID0", "Scarpe", 125, "Nike", "Scarpe bellissime");
            prodotti[1] = new Prodotto("ID1", "Maglietta", 115, "Nike", "Maglietta bellissima");
            prodotti[2] = new Prodotto("ID2", "Vaso", 5, "Nike", "Vaso bellissimo");
            prodotti[3] = new Prodotto("ID3", "Scarponi", 155, "Nike", "Scarponi bellissimi");
            prodotti[4] = new Prodotto("ID4", "Set di matite", 12, "Giotto", "Matite bellissime");
        }

        private void aggiungiButton_Click(object sender, EventArgs e)
        {
            if (nomeAggiungi.Text != null)
            {
                try
                {
                    carrello.aggiungi(ricercaProdotto(nomeAggiungi.Text, numProdotti));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Prodotto non trovato");
                }
            }
        }

        private void prodottiButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = stampaProdotti();
        }
        private string stampaProdottiCarrello()
        {
            string stampa="ID NOME PREZZO DESCRIZONE \t\n";
            for(int i = 0; i < numProdotti; i++)
            {
                stampa += $"{prodotti[i].ID} {prodotti[i].Name} {prodotti[i].Prezzo.ToString()} {prodotti[i].Descrizione}\t\n"; 
            }
            return stampa;
        }
        private string stampaProdotti()
        {
            string stampa = "ID NOME PREZZO DESCRIZONE \t\n";
            for (int i = 0; i < numProdotti; i++)
            {
                stampa += $"{carrello.Prodotti[i].ID} {carrello.Prodotti[i].Name} {carrello.Prodotti[i].Prezzo.ToString()} {carrello.Prodotti[i].Descrizione}\t\n";
            }
            return stampa;
        }
        private Prodotto ricercaProdotto(string ID, int cont)
        {
            for(int i = 0; i < cont; i++)
            {
                if(prodotti[i].ID == ID)
                {
                    return prodotti[i];
                }
            }
            throw new Exception("Prodotto non trovato");

        }

        private void rimuoviButton_Click(object sender, EventArgs e)
        {
            if (rimuoviBox.Text != null)
            {
                try
                {
                    Prodotto idProdotto = new Prodotto(rimuoviBox.Text);
                    carrello.rimuovi(idProdotto);
                    MessageBox.Show("Prodotto rimosso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Prodotto non trovato nel carrello");
                }
            } 
        }

        private void carrelloButton_Click(object sender, EventArgs e)
        {
            if (carrello.Prodotti != null)
            {
                richTextBox1.Text = stampaProdottiCarrello();
            } else
            {
                MessageBox.Show("Il carrello è vuoto");
            }
        }
    }
}
