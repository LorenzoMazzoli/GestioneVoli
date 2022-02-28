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
    public partial class frmAeromobili : Form
    {
        public frmAeromobili()
        {
            InitializeComponent();
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddAeromobile formAggiungiAeromobile = new frmAddAeromobile();

            formAggiungiAeromobile.ShowDialog();
        }

        private void btnCheckAeromobile_Click(object sender, EventArgs e)
        {
            frmCheckAeromobili formControllaAeromobili = new frmCheckAeromobili();

            formControllaAeromobili.ShowDialog();
        }
    }
}
