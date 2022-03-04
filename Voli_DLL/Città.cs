using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voli_Library
{
     public class Citta
    {
        string Nome { get; set; }
        public Citta()
        {
            Nome = "";
        }
        public Citta(string nome)
        {
            Nome = nome;
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public string SetNome
        {
            set { Nome = value; }
        }
    }
}
