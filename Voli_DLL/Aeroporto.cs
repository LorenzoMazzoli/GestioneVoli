using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voli_Library
{
    public class Aeroporto
    {
        string Nome { get; set; }
        string Codice { get; set; }

        Nazione nazioneDiAppartenenza;

        public Aeroporto(string nome, string codice, Nazione nazionePassata) 
        {
            Nome = nome;
            Codice = codice;
            nazioneDiAppartenenza = nazionePassata;
        }
    }
}
