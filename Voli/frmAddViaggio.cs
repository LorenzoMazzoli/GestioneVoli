﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Voli_Library;
using Telerik;

namespace Voli
{
    public partial class frmAddViaggio : Form
    {
        CompagniaAerea compagnia = new CompagniaAerea();
        Pilota pilota;
        Pilota coPilota;
        DateTime giornoViaggio;
        List<Assistente> assistentiPassati;
        List<Assistente> assistentiViaggio;
        
        public frmAddViaggio(CompagniaAerea compagnia)
        {
            InitializeComponent();
            this.compagnia = compagnia;
            assistentiPassati = compagnia.GetAssistenti();
            assistentiViaggio = new List<Assistente>();
        }

        private void frmAddViaggio_Load(object sender, EventArgs e)
        {
            foreach (Pilota p in compagnia.GetPiloti())
            {
                cmbSelectPilota.Items.Add(p.GetNomeCognome());
                cmbSelectCopilota.Items.Add(p.GetNomeCognome());
            }
            foreach (Assistente a in assistentiPassati)
            {
                clbSelectAssistenti.Items.Add(a.GetNomeCognome());
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            foreach (Pilota p in compagnia.GetPiloti())
            {
                if (cmbSelectPilota.Text==p.GetNomeCognome())
                {
                    pilota = p;
                }
                if (cmbSelectCopilota.Text == p.GetNomeCognome())
                {
                    coPilota = p;
                }
            }
            giornoViaggio = dtpSelectGiorno.Value;
            foreach (Assistente a in assistentiPassati)
            {
                foreach (string s in clbSelectAssistenti.CheckedItems)
                {
                    if (s == a.GetNomeCognome())
                    {
                        assistentiViaggio.Add(a);
                    }
                }
            }
           
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            Close();
        }

        public DateTime GetGiorno()
        {
            return giornoViaggio;
        }

        public Pilota GetPilota()
        {
            return pilota;
        }

        public Pilota GetCopilota()
        {
            return coPilota;
        }

        public List<Assistente> GetAssistenti()
        {
            return assistentiViaggio;
        }
    }
}