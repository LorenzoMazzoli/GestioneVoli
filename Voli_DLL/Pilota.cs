using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voli_Library
{
    public class Pilota : Persona
    {
        string Grado { get; set; }
        public Pilota(string nome, string cognome, DateTime nascita) : base(nome, cognome, nascita)
        {
            Grado = "";
        }
        public Pilota(string nome, string cognome, DateTime nascita, string grado) : base(nome, cognome, nascita)
        {
            Grado = grado;
        }

        public string GetGrado()
        {
            return Grado;
        }
        
        public override string GetInfo()
        {
            return base.GetInfo() + $" - Grado: {this.Grado}";
        }


    }
}
