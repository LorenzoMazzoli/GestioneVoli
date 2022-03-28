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

        Pilota pilotaPrincipale;
        Pilota coPilota;

        List<Assistente> assistentiViaggio = new List<Assistente>();
        Volo volo;
        public Viaggio()
        {
            dataPartenza = DateTime.MinValue;
            pilotaPrincipale = null;
            coPilota = null;
            assistentiViaggio = new List<Assistente>();
            volo = null;
        }
        public Viaggio(DateTime partenza, Pilota pilotaPrin, Pilota coPil, List<Assistente> assistenti)
        {
            dataPartenza = partenza;
            pilotaPrincipale = pilotaPrin;
            coPilota = coPil;
            assistentiViaggio = assistenti;
        }
        public Viaggio(DateTime partenza, Pilota pilotaPrin, Pilota coPil, List<Assistente> assistenti, Volo voloPassato)
        {
            dataPartenza = partenza;
            pilotaPrincipale = pilotaPrin;
            coPilota = coPil;
            assistentiViaggio = assistenti;
            volo = voloPassato;
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
                if (a == assistentiViaggio.Last())
                {
                    outString += $"{a.GetNome()} ";
                }
                else
                {
                    outString += $"{a.GetNome()}, ";
                }
            }

            return outString;
        }
        public Volo GetVolo()
        {
            return this.volo;
        }
        public string GetInfo()
        {
            return $"Data di partenza: {this.dataPartenza} - Pilota: {this.pilotaPrincipale.GetNomeCognome()} - Co Pilota: {this.coPilota.GetNomeCognome()} - Assistenti: {this.GetNomiAssistenti()} - Volo: {volo.GetInfo()}";
        }
    }
}
