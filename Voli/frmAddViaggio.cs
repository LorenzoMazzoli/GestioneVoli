using System;
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
        Volo volo;
        
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
            foreach(Volo v in compagnia.GetVoli())
            {
                lbVoli.Items.Add(v.GetInfo());
            }
            
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (cmbSelectCopilota.Text == cmbSelectPilota.Text)
            {
                MessageBox.Show("Piloti selezionati non validi");
            }
            if (cmbSelectPilota.SelectedItem == null || cmbSelectCopilota.SelectedItem == null || clbSelectAssistenti.SelectedItems==null || lbVoli.SelectedItem==null)
            {
                MessageBox.Show("Inserire tutti i valori");
            }
            else
            {
                foreach (Pilota p in compagnia.GetPiloti())
                {
                    if (cmbSelectPilota.Text == p.GetNomeCognome())
                    {
                        pilota = p;
                    }
                    if (cmbSelectCopilota.Text == p.GetNomeCognome())
                    {
                        coPilota = p;
                    }
                }
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
                foreach (Volo v in compagnia.GetVoli())
                {
                    foreach (string s in lbVoli.SelectedItems)
                    {
                        if (s == v.GetInfo())
                        {
                            volo = v;
                        }
                    }
                }
                foreach (Control c in Controls)
                {
                    if (c is ComboBox)
                    {
                        c.Text = "";
                    }
                    
                }
                dtpSelectGiorno.Value = DateTime.Now;
                foreach (int i in clbSelectAssistenti.CheckedIndices)
                {
                    clbSelectAssistenti.SetItemCheckState(i, CheckState.Unchecked);
                }
                clbSelectAssistenti.ClearSelected();
                lbVoli.ClearSelected();
            }
            if (dtpSelectGiorno.Value>DateTime.Now)
            {
                MessageBox.Show("data inserita non valida");
            }
            else
            {
                giornoViaggio = dtpSelectGiorno.Value;
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

        public Volo GetVolo()
        {
            return volo;
        }
    }
}
