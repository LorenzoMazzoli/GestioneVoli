using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voli_Library
{
    public class Aeroporto
    {
        string Nome { get; set; }
        string Codice { get; set; }

        Citta cittaDiAppartenza;
        public Aeroporto()
        {
            Nome = "";
            Codice = "";
        }
        public Aeroporto(string nome, string codice, Citta cittaPassata) 
        {
            Nome = nome;
            Codice = codice;
            cittaDiAppartenza = cittaPassata;
        }

        public string GetNome()
        {
            return this.Nome;
        }
    }
}
