using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voli_Library
{
    class Aeromobile
    {
        string Matricola { get; set; }
        string Modello { get; set; }
        string Marca { get; set; }
        DateTime annoAcquisto { get; set; }

        public Aeromobile(string matricola, string modello, string marca, DateTime acquisto)
        {
            Matricola = matricola;
            Modello = modello;
            Marca = marca;
            annoAcquisto = acquisto;
        }

        public string GetInfo()
        {
            return $"{Matricola} + ";
        }
    }
}
