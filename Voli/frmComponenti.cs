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
    public partial class frmComponenti : Form
    {
        public frmComponenti()
        {
            InitializeComponent();
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVoli_Click(object sender, EventArgs e)
        {
            frmVoli formVoli = new frmVoli();

            formVoli.ShowDialog();
        }

        private void btnPersonale_Click(object sender, EventArgs e)
        {
            frmPersonale formPersonale = new frmPersonale();

            formPersonale.ShowDialog();
        }

        private void btnAeroporti_Click(object sender, EventArgs e)
        {

        }

        private void btnAeromobili_Click(object sender, EventArgs e)
        {

        }
    }
}
