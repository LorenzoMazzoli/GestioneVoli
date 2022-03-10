using System;

namespace Voli_Library
{
    public class Volo
    {
        string Codice { get; set; }

        TimeSpan orarioDiPartenza;
        TimeSpan orarioDiArrivo;

        Aeroporto aeroportoPartenza;
        Aeroporto aeroportoArrivo;
        public Volo()
        {
            Codice = "";
            orarioDiArrivo = TimeSpan.MinValue;
            orarioDiPartenza = TimeSpan.MinValue;
            aeroportoPartenza = null;
            aeroportoArrivo = null;
        }
        public Volo(string codice, TimeSpan orarioPartenza, TimeSpan orarioArrivo, Aeroporto partenza, Aeroporto arrivo)
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

        public TimeSpan GetOrarioArrivo()
        {
            return this.orarioDiArrivo;
        }

        public TimeSpan GetOrarioPartenza()
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

        public string GetInfo()
        {
            return $"Codice: {this.Codice} - Orario di Partenza: h{this.orarioDiPartenza.ToString("hh\\mm\\ss")} da: {this.aeroportoPartenza.GetNome()} - orario di arrivo: h{this.orarioDiArrivo.ToString("hh\\mm\\ss")} a {this.aeroportoArrivo.GetNome()}";
        }
    }
}
