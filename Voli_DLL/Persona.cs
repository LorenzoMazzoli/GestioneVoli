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

        public string GetNome()
        {
            return this.Nome;
        }

        public string GetCognome()
        {
            return this.Cognome;
        }
        public DateTime GetDataNascita()
        {
            return this.dataNascita;
        }

        public virtual string GetInfo()
        {
            return $"Nome: {this.Nome} - Cognome: {this.Cognome} - Data di nascita: {this.dataNascita.ToString()}";
        }
    }
}
