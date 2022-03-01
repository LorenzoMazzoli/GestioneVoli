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
            frmAddVolo formAddVolo = new frmAddVolo();

            formAddVolo.ShowDialog();
        }

        private void btnAddPilota_Click(object sender, EventArgs e)
        {

            frmAddPersonale formAddPilota = new frmAddPersonale(true);

            formAddPilota.ShowDialog();
        }

        private void btnAeroporti_Click(object sender, EventArgs e)
        {
            frmAddAeroporto formAddAeroporto = new frmAddAeroporto();

            formAddAeroporto.ShowDialog();
        }

        private void btnAeromobili_Click(object sender, EventArgs e)
        {
            frmAddAeromobile formAddAeromobile = new frmAddAeromobile();

            formAddAeromobile.ShowDialog();
        }

        private void btnCheckVoli_Click(object sender, EventArgs e)
        {
            frmCheckVoli formCheckVoli = new frmCheckVoli();

            formCheckVoli.ShowDialog();
        }

        private void btnCheckAeroporti_Click(object sender, EventArgs e)
        {
            frmCheckAeroporti formCheckAeroporti = new frmCheckAeroporti();

            formCheckAeroporti.ShowDialog();
        }

        private void btnCheckPersonale_Click(object sender, EventArgs e)
        {
            frmCheckPersonale formCheckPersonale = new frmCheckPersonale();

            formCheckPersonale.ShowDialog();
        }

        private void btnCheckAeromobili_Click(object sender, EventArgs e)
        {
            frmCheckAeromobili formCheckAeromobili = new frmCheckAeromobili();

            formCheckAeromobili.ShowDialog();
        }

        private void btnAddPersonale_Click(object sender, EventArgs e)
        {
            frmAddPersonale formAddAssistente = new frmAddPersonale(false);

            formAddAssistente.ShowDialog();
        }

        private void frmComponenti_Load(object sender, EventArgs e)
        {
            
        }
    }
}
