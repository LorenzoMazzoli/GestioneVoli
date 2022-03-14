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

namespace Voli
{
    public partial class frmAddAeromobile : Form
    {   
        string Modello { get; set; }
        string Marca { get; set; }
        string Matricola { get; set; }
        DateTime DataAcquisto { get; set; }
        public frmAddAeromobile()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtModello.Text == "" || txtMarca.Text=="" || txtMatricola.Text=="" )
            {
                MessageBox.Show("Inserire tutti i valori");
            }
            else
            {
                if (dtpDataAcquisto.Value > DateTime.Now)
                {
                    MessageBox.Show("Data di acquisto non valida");
                    dtpDataAcquisto.Value = DateTime.Now;
                }
                else
                {
                    Modello = txtModello.Text;
                    Marca = txtMarca.Text;
                    Matricola = txtMatricola.Text;
                    DataAcquisto = dtpDataAcquisto.Value;
                    foreach (Control c in Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }
                    dtpDataAcquisto.Value = DateTime.Now;
                }
                
            }
            
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            Close();
        }
        public string GetModello()
        {
            return this.Modello;
        }

        public string GetMarca()
        {
            return this.Marca;
        }

        public string GetMatricola()
        {
            return this.Matricola;
        }

        public DateTime GetDataAcquisto()
        {
            return this.DataAcquisto;
        }
    }
}
