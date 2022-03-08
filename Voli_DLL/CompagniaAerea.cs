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
        List<Volo> voli;
        List<Citta> cittas;
        public CompagniaAerea()
        {
            aeromobili = new List<Aeromobile>();
            aeroporti = new List<Aeroporto>();
            piloti = new List<Pilota>();
            assistenti = new List<Assistente>();
            voli = new List<Volo>();
            cittas = new List<Citta>();
        }
        public CompagniaAerea(string nome)
        {
            Nome = nome;
            aeromobili = new List<Aeromobile>();
            aeroporti = new List<Aeroporto>();
            piloti = new List<Pilota>();
            assistenti = new List<Assistente>();
            voli = new List<Volo>();
            cittas = new List<Citta>();
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

        public void AddCitta(Citta citta)
        {
            cittas.Add(citta);
        }

        public void AddVolo(Volo volo)
        {
            voli.Add(volo);
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

        public List<Volo> GetVoli()
        {
            return voli;
        }

        public List<Citta> GetCittas()
        {
            return cittas;
        }
    }
}
