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
         
            Modello = txtModello.Text;
            Marca = txtMarca.Text;
            Matricola = txtMatricola.Text;
            DataAcquisto = dtpDataAcquisto.Value;
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
