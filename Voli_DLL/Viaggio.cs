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

        List<Assistente> assistentiViaggio;
        public Viaggio()
        {
            dataPartenza = DateTime.MinValue;
            statoVolo = "";
            pilotaPrincipale = null;
            coPilota = null;
            assistentiViaggio = new List<Assistente>();
        }
        public Viaggio(DateTime partenza, Pilota pilotaPrin, Pilota coPil)
        {
            dataPartenza = partenza;
            statoVolo = "Previsto";
            pilotaPrincipale = pilotaPrin;
            coPilota = coPil;
            assistentiViaggio = new List<Assistente>();
        }
    }
}
