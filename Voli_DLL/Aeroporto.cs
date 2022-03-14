using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voli_Library;

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

        public string GetCodice()
        {
            return this.Codice;
        }

        public Citta GetCitta()
        {
            return this.cittaDiAppartenza;
        }

        public string GetNomeCitta()
        {
            return this.cittaDiAppartenza.GetNome();
        }

        public string GetInfo()
        {
            return $"Nome: {this.Nome} - Codice: {this.Codice} - Città di appartenenza: {this.GetNomeCitta()}";
        }
    }
}
