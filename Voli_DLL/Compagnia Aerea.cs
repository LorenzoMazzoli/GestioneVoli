using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voli_Library
{
    class HUB
    {
        List<Aeromobile> aeromobili;
        List<Aeroporto> aeroporti;
        List<Pilota> piloti;
        List<Assistente> assistenti;

        public HUB()
        {
            aeromobili = new List<Aeromobile>();
            aeroporti = new List<Aeroporto>();
            piloti = new List<Pilota>();
            assistenti = new List<Assistente>();
        }

        public void AddAeroporto(Aeromobile aero)
        {
            aeromobili.Add(aero); //aggiunge un aeromobile alla lista
        }

        public void AddAeroporto(Aeroporto aPorto)
        {
            aeroporti.Add(aPorto); //aggiunge un aeroporto alla lista
        }

        public void AddPilota(Pilota pilot)
        {
            piloti.Add(pilot); //aggiunge un pilota alla lista
        }

        public void AddAssistente(Assistente assist)
        {
            assistenti.Add(assist); //aggiunge un assistente alla lista
        }
    }
}
