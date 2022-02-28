using System;

namespace Voli_Library
{
    public class Volo
    {
        string Codice { get; set; }

        DateTime orarioDiPartenza;
        DateTime orarioDiArrivo;

        Aeroporto aeroportoPartenza;
        Aeroporto aeroportoArrivo;

        public Volo(string codice, DateTime orarioPartenza, DateTime orarioArrivo, Aeroporto partenza, Aeroporto arrivo)
        {
            Codice = codice;
            orarioDiPartenza = orarioPartenza;
            orarioDiArrivo = orarioArrivo;
            aeroportoPartenza = partenza;
            aeroportoArrivo = arrivo;
        }
    }
}
