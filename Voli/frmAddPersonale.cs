using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voli
{
    public partial class frmAddPersonale : Form
    {
        string Nome { get; set; }
        string Cognome { get; set; }
        DateTime DataNascita { get; set; }
        string Grado { get; set; }
        string Qualifica { get; set; }
        public frmAddPersonale(bool cliccato)
        {
            InitializeComponent();
            //utilizziamo una sola form sia per aggiungere i piloti che per aggiungere gli assistenti, quindi con una variabile booleana
            //controlliamo che il pulsante sia stato cliccato per aggiungere un pilota o un assistente, eliminando label e combobox non necessari
            if (cliccato == true)
            {
                lblQualifica.Dispose();
                cmbQualifica.Dispose();
                
            }
            else
            {
                lblGrado.Dispose();
                cmbGrado.Dispose();
            }
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            // per lo stesso principio di prima, controllo quale label e quale combobox sono presenti, per passare i parametri del futuro oggetto
            if (lblQualifica.Disposing != true)
            {
                Nome = txtNome.Text;
                Cognome = txtCognome.Text;
                DataNascita = dtpDataNascita.Value;
                Grado = (string)cmbGrado.SelectedItem;
            }
            else
            {
                Nome = txtNome.Text;
                Cognome = txtCognome.Text;
                DataNascita = dtpDataNascita.Value;
                Qualifica = (string)cmbQualifica.SelectedItem;
            }
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public string GetCognome()
        {
            return this.Cognome;
        }
        public DateTime GetDataNascita()
        {
            return this.DataNascita;
        }

        public string GetQualifica()
        {
            return this.Qualifica;
        }
        public string GetGrado()
        {
            return this.Grado;
        }
    }
}
