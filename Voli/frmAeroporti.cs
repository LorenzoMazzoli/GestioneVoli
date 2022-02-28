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
    public partial class frmAeroporti : Form
    {
        public frmAeroporti()
        {
            InitializeComponent();
        }

        private void btnAggiungiAeroporto_Click(object sender, EventArgs e)
        {
            frmAddAeroporto formAggiungiAeroporto = new frmAddAeroporto();

            formAggiungiAeroporto.ShowDialog();
        }

        private void btnCheckAeroporti_Click(object sender, EventArgs e)
        {
            frmCheckAeroporti formControllaAeroporti = new frmCheckAeroporti();
        }
    }
}
