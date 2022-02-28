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
    public partial class frmPersonale : Form
    {
        public frmPersonale()
        {
            InitializeComponent();
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPilota_Click(object sender, EventArgs e)
        {
            frmPilota formPilota = new frmPilota();

            formPilota.ShowDialog();
        }

        private void btnAssistente_Click(object sender, EventArgs e)
        {
            frmAssistente formAssistente = new frmAssistente();

            formAssistente.ShowDialog();
        }
    }
}
