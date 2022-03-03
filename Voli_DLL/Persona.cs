using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voli_Library
{
    public class Persona
    {
        string Nome { get; set; }
        string Cognome { get; set; }
        
        DateTime dataNascita;
        public Persona()
        {
            Nome = "";
            Cognome = "";
            dataNascita = DateTime.MinValue;
        }
        public Persona(string nome, string cognome, DateTime nascita)
        {
            Nome = nome;
            Cognome = cognome;
            dataNascita = nascita;
        }
    }
}
