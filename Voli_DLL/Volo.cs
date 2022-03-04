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
        public Volo()
        {
            Codice = "";
            orarioDiArrivo = DateTime.MinValue;
            orarioDiPartenza = DateTime.MinValue;
            aeroportoPartenza = null;
            aeroportoArrivo = null;
        }
        public Volo(string codice, DateTime orarioPartenza, DateTime orarioArrivo, Aeroporto partenza, Aeroporto arrivo)
        {
            Codice = codice;
            orarioDiPartenza = orarioPartenza;
            orarioDiArrivo = orarioArrivo;
            aeroportoPartenza = partenza;
            aeroportoArrivo = arrivo;
        }

        public string GetCodice()
        {
            return this.Codice;
        }

        public DateTime GetOrarioArrivo()
        {
            return this.orarioDiArrivo;
        }

        public DateTime GetOrarioPartenza()
        {
            return this.orarioDiPartenza;
        }

        public Aeroporto GetAeroportoArrivo()
        {
            return this.aeroportoArrivo;
        }

        public Aeroporto GetAeroportoPartenza()
        {
            return this.aeroportoPartenza;
        }
    }
}
