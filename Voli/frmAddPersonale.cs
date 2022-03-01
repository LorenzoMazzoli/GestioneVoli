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
        public frmAddPersonale(bool cliccato)
        {
            InitializeComponent();
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
    }
}
