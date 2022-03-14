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
    public partial class frmAddVolo : Form
    {
        string Codice { get; set; }
        Aeroporto AeroportoPartenza;        
        Aeroporto AeroportoArrivo;
        TimeSpan orarioPartenza;
        TimeSpan orarioArrivo;
        List<Aeroporto> AeroportiArrivo = new List<Aeroporto>();
        List<Aeroporto> AeroportiPartenza = new List<Aeroporto>();
        List<string> nomiAeroportiArrivo = new List<string>();
        List<string> nomiAeroportiPartenza = new List<string>();
        
        public frmAddVolo(List<Aeroporto> aeroporti)
        {
            InitializeComponent();
            foreach (Aeroporto a in aeroporti)
            {
                this.AeroportiArrivo.Add(a);
                this.AeroportiPartenza.Add(a);
                nomiAeroportiPartenza.Add(a.GetNome());
                nomiAeroportiArrivo.Add(a.GetNome());
            }
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddVolo_Load(object sender, EventArgs e)
        {
            cmbAeroportiPartenza.DataSource = nomiAeroportiPartenza;
            cmbAeroportiArrivo.DataSource = nomiAeroportiArrivo;

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtCodiceVolo.Text == "" || cmbAeroportiArrivo.SelectedItem == null || cmbAeroportiPartenza.SelectedItem == null)
            {
                MessageBox.Show("Inserire tutti i valori");
            }
            else
            {
                if (rtmOrarioArrivo.Value<rtmOrarioPartenza.Value)
                {
                    MessageBox.Show("Orario di arrivo non valido");
                }
                if (cmbAeroportiPartenza.SelectedItem == cmbAeroportiArrivo.SelectedItem)
                {
                    MessageBox.Show("Aeroporti non validi");
                }
                else
                {
                    Codice = txtCodiceVolo.Text;
                    foreach (Aeroporto a in AeroportiPartenza)
                    {
                        if (a.GetNome() == (string)cmbAeroportiPartenza.SelectedItem)
                        {
                            AeroportoPartenza = a;
                        }

                    }
                    foreach (Aeroporto a in AeroportiArrivo)
                    {
                        if (a.GetNome() == (string)cmbAeroportiArrivo.SelectedItem)
                        {
                            AeroportoArrivo = a;
                        }
                    }
                    orarioPartenza = (TimeSpan)rtmOrarioPartenza.Value.Value.TimeOfDay;
                    orarioArrivo = (TimeSpan)rtmOrarioArrivo.Value.Value.TimeOfDay;
                    foreach (Control c in Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }
                    cmbAeroportiPartenza.Text = "";
                    cmbAeroportiArrivo.Text = "";
                }
          
            }
        }

        public string GetCodice()
        {
            return this.Codice;
        }

        public Aeroporto GetAeroportoPartenza()
        {
            return this.AeroportoPartenza;
        }
        public Aeroporto GetAeroportoArrivo()
        {
            return this.AeroportoArrivo;
        }

        public TimeSpan GetOrarioPartenza()
        {
            return this.orarioPartenza;
        }

        public TimeSpan GetOrarioArrivo()
        {
            return this.orarioArrivo;
        }
    }
}
