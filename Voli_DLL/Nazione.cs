using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voli_Library
{
    public class Nazione
    {
        string Nome { get; set; }

        List<Citta> cities;
        public Nazione()
        {
            Nome = "";
            cities = new List<Citta>();
        }
        public Nazione(string nome) 
        {
            Nome = nome;
            cities = new List<Citta>();
        }

        public void AddCitta(Citta cittaPassata)
        {
            cities.Add(cittaPassata);
        }
    }
}
