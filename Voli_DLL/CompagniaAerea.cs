using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voli_Library
{
    public class CompagniaAerea
    {
        string Nome { get;}

        List<Aeromobile> aeromobili;
        List<Aeroporto> aeroporti;
        List<Pilota> piloti;
        List<Assistente> assistenti;
        public CompagniaAerea()
        {
            aeromobili = new List<Aeromobile>();
            aeroporti = new List<Aeroporto>();
            piloti = new List<Pilota>();
            assistenti = new List<Assistente>();
        }
        public CompagniaAerea(string nome)
        {
            Nome = nome;
            aeromobili = new List<Aeromobile>();
            aeroporti = new List<Aeroporto>();
            piloti = new List<Pilota>();
            assistenti = new List<Assistente>();
        }

        public void AddAeromobile(Aeromobile aero)
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
        public List<Aeroporto> GetAeroporti()
        {
            return aeroporti;
        }

        public List<Aeromobile> GetAeromobili()
        {
            return aeromobili;
        }

        public List<Assistente> GetAssistenti()
        {
            return assistenti;
        }
        public List<Pilota> GetPiloti()
        {
            return piloti;
        }
    }
}
