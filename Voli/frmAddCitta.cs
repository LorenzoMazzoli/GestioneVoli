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
    //win merge
    public partial class frmAddCitta : Form
    {
        string Nome;
        public frmAddCitta()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtNomeCitta.Text=="")
            {
                MessageBox.Show("Inserire il nome della città");
            }
            else
            {
                Nome = txtNomeCitta.Text;
            }
        }

        public string GetNome()
        {
            return this.Nome;
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
