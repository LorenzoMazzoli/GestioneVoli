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
    public partial class frmComponenti : Form
    {
        CompagniaAerea compagnia = new CompagniaAerea();
        
        public frmComponenti(CompagniaAerea compagnia)
        {
            InitializeComponent();
            this.compagnia = compagnia;
        }
        private void frmComponenti_Load(object sender, EventArgs e)
        {
           
        }

        private void btnVoli_Click(object sender, EventArgs e)
        {
            frmAddVolo formAddVolo = new frmAddVolo(compagnia.GetAeroporti());

            formAddVolo.ShowDialog();

            compagnia.AddVolo(new Volo(formAddVolo.GetCodice(), formAddVolo.GetOrarioPartenza(), formAddVolo.GetOrarioArrivo(), formAddVolo.GetAeroportoPartenza(), formAddVolo.GetAeroportoArrivo()));
        }

        private void btnAddPilota_Click(object sender, EventArgs e)
        {
            frmAddPersonale formAddPilota = new frmAddPersonale(true);

            formAddPilota.ShowDialog();

            compagnia.AddPilota(new Pilota(formAddPilota.GetNome(), formAddPilota.GetCognome(), formAddPilota.GetDataNascita(), formAddPilota.GetGrado()));
        }

        private void btnAeroporti_Click(object sender, EventArgs e)
        {
            frmAddAeroporto formAddAeroporto = new frmAddAeroporto(compagnia.GetCittas());

            formAddAeroporto.ShowDialog();

            compagnia.AddAeroporto(new Aeroporto(formAddAeroporto.GetNome(), formAddAeroporto.GetCodice(), formAddAeroporto.GetCitta()));
        }

        private void btnAeromobili_Click(object sender, EventArgs e)
        {
            frmAddAeromobile formAddAeromobile = new frmAddAeromobile();

            formAddAeromobile.ShowDialog();

            compagnia.AddAeromobile(new Aeromobile(formAddAeromobile.GetMatricola(), formAddAeromobile.GetMarca(), formAddAeromobile.GetModello(), formAddAeromobile.GetDataAcquisto()));
        }
        private void btnAddAssistente_Click(object sender, EventArgs e)
        {
            frmAddPersonale formAddAssistente = new frmAddPersonale(false);

            formAddAssistente.ShowDialog();

            compagnia.AddAssistente(new Assistente(formAddAssistente.GetNome(), formAddAssistente.GetCognome(), formAddAssistente.GetDataNascita(), formAddAssistente.GetGrado()));

        }

        private void btnAddCitta_Click(object sender, EventArgs e)
        {
            frmAddCitta formAddCitta = new frmAddCitta();

            formAddCitta.ShowDialog();

            compagnia.AddCitta(new Citta(formAddCitta.GetNome()));
        }

        private void btnCheckVoli_Click(object sender, EventArgs e)
        {
            frmCheckVoli formCheckVoli = new frmCheckVoli(compagnia.GetVoli());

            formCheckVoli.ShowDialog();
        }

        private void btnCheckAeroporti_Click(object sender, EventArgs e)
        {
            frmCheckAeroporti formCheckAeroporti = new frmCheckAeroporti(compagnia.GetAeroporti());

            formCheckAeroporti.ShowDialog();
        }

        private void btnCheckPersonale_Click(object sender, EventArgs e)
        {
            frmCheckPersonale formCheckPersonale = new frmCheckPersonale(compagnia.GetPiloti(), compagnia.GetAssistenti());

            formCheckPersonale.ShowDialog();
        }

        private void btnCheckAeromobili_Click(object sender, EventArgs e)
        {
            frmCheckAeromobili formCheckAeromobili = new frmCheckAeromobili(compagnia.GetAeromobili());

            formCheckAeromobili.ShowDialog();
        }

        
        private void btnCheckCitta_Click(object sender, EventArgs e)
        {
            frmCheckCitta formCeckCitta = new frmCheckCitta(compagnia.GetCittas());

            formCeckCitta.ShowDialog();
        }
        private void btnChiudi_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
