using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceColombi
{
    public class Prodotto
    {
        private string _id;
        private string _name;
        private float _prezzo;
        private string _produttore;
        private string _descrizione;
        public string ID
        {
            get { return _id; }
            private set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public string Produttore
        {
            get { return _produttore; }
            private set { _produttore = value; }
        }
        public float Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }
        public string Descrizione
        {
            get { return _descrizione;  }
            private set
            {
                _descrizione = value;
            }
        }
        public Prodotto(string id, string name, float prezzo, string produttore, string descrizione)
        {
            ID = id;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Produttore = produttore;
            Name = name;
        }
        public Prodotto(string id)
        {
            ID = id;
        }
    }
}
