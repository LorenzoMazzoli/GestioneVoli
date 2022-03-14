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
                lblQualifica.Visible = false;
                cmbQualifica.Visible = false;
            }
            else
            {
                lblGrado.Visible = false;
                cmbGrado.Visible = false;
            }
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            // per lo stesso principio di prima, controllo quale label e quale combobox sono presenti, per passare i parametri del futuro oggetto
            if (lblQualifica.Visible != true)
            { 
                if (txtNome.Text == "" || txtCognome.Text == "" || cmbGrado.SelectedItem == null)
                {
                    MessageBox.Show("Inserire tutti i valori");
                }
                else
                {
                    if (dtpDataNascita.Value > DateTime.Now)
                    {
                        MessageBox.Show("Data di nascita non valida");
                        dtpDataNascita.Value = DateTime.Now;
                    }
                    else
                    {
                        Nome = txtNome.Text;
                        Cognome = txtCognome.Text;
                        DataNascita = dtpDataNascita.Value;
                        Grado = (string)cmbGrado.SelectedItem;
                        foreach (Control c in Controls)
                        {
                            if (c is TextBox)
                            {
                                c.Text = "";
                            }
                            cmbGrado.Text = "";
                        }
                        dtpDataNascita.Value = DateTime.Now;
                    }
                }
            }
            else
            {
                if (txtNome.Text == "" || txtCognome.Text == "" || cmbQualifica.SelectedItem == null)
                {
                    MessageBox.Show("Inserire tutti i valori");
                }
                else
                {
                    if (dtpDataNascita.Value > DateTime.Now)
                    {
                        MessageBox.Show("Data di nascita non valida");
                        dtpDataNascita.Value = DateTime.Now;
                    }
                    else
                    {
                        Nome = txtNome.Text;
                        Cognome = txtCognome.Text;
                        DataNascita = dtpDataNascita.Value;
                        Qualifica = (string)cmbQualifica.SelectedItem;
                        foreach (Control c in Controls)
                        {
                            if (c is TextBox)
                            {
                                c.Text = "";
                            }
                            cmbQualifica.Text = "";
                        }
                        dtpDataNascita.Value = DateTime.Now;
                    }
                }
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
