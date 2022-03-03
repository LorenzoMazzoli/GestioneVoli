﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voli_Library
{
    public class Assistente : Persona
    {
        string Qualifica { get; set; }
        public Assistente(string nome, string cognome, DateTime nascita) : base(nome, cognome, nascita)
        {
            Qualifica = "";
        }
        public Assistente(string nome, string cognome, DateTime nascita, string qualifica) : base(nome, cognome, nascita)
        {
            Qualifica = qualifica;
        }
    }
}
