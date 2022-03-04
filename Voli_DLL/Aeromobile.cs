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
        DateTime DataAcquisto { get; set; }
        public Aeromobile()
        {
            Matricola = "";
            Modello = "";
            Marca = "";
            DataAcquisto = DateTime.MinValue;

        }
        public Aeromobile(string matricola, string modello, string marca, DateTime acquisto)
        {
            Matricola = matricola;
            Modello = modello;
            Marca = marca;
            DataAcquisto = acquisto;
        }

        public string GetMatricola()
        {
            return this.Matricola;
        }

        public string GetModello()
        {
            return this.Modello;
        }

        public string GetMarca()
        {
            return this.Marca;
        }

        public DateTime GetDataAcquisto()
        {
            return this.DataAcquisto;
        }

        public string GetInfo()
        {
            return $"Matricola: {this.Matricola} - Marca: {this.Marca} - Modello: {this.Modello} - Data d'acquisto: {this.DataAcquisto.ToString()}";
        }
    }
}
