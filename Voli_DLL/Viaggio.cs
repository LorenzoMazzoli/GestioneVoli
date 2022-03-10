using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voli_Library
{
    public class Viaggio
    {
        DateTime dataPartenza;
        string statoVolo;

        Pilota pilotaPrincipale;
        Pilota coPilota;

        List<Assistente> assistentiViaggio = new List<Assistente>();
        public Viaggio()
        {
            dataPartenza = DateTime.MinValue;
            statoVolo = "";
            pilotaPrincipale = null;
            coPilota = null;
            assistentiViaggio = new List<Assistente>();
        }
        public Viaggio(DateTime partenza, Pilota pilotaPrin, Pilota coPil, List<Assistente> assistenti)
        {
            dataPartenza = partenza;
            statoVolo = "Previsto";
            pilotaPrincipale = pilotaPrin;
            coPilota = coPil;
            assistentiViaggio = assistenti;
        }

        private List<Assistente> GetAssistenti()
        {
            return assistentiViaggio;
        }
        private string GetNomiAssistenti()
        {
            string outString = "";

            foreach (Assistente a in assistentiViaggio)
            {
                outString += $"{a.GetNome()}; ";
            }

            return outString;
        }

        public string GetInfo()
        {
            return $"Data di partenza: {this.dataPartenza} - stato del volo: {this.statoVolo} - Pilota: {this.pilotaPrincipale} - Co Pilota: {this.coPilota} - Assistenti: {this.GetNomiAssistenti()}";
        }
    }
}
