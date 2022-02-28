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
    public partial class frmVoli : Form
    {
        public frmVoli()
        {
            InitializeComponent();
        }

        private void btnAggiungiVolo_Click(object sender, EventArgs e)
        {
            frmAddVolo formAggiungiVolo = new frmAddVolo();

            formAggiungiVolo.ShowDialog();
        }

        private void btnCheckVoli_Click(object sender, EventArgs e)
        {
            frmCheckVoli formControllaVoli = new frmCheckVoli();

            formControllaVoli.ShowDialog();
        }
    }
}
