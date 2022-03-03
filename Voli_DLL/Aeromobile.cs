using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voli_Library
{
    public class Aeromobile
    {
        string Matricola { get; set; }
        string Modello { get; set; }
        string Marca { get; set; }
        DateTime annoAcquisto { get; set; }
        public Aeromobile()
        {
            Matricola = "";
            Modello = "";
            Marca = "";
            annoAcquisto = DateTime.MinValue;

        }
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
