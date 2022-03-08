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
        CompagniaAerea compagnia;
        
        public frmComponenti()
        {
            InitializeComponent();
        }
        private void frmComponenti_Load(object sender, EventArgs e)
        {
            compagnia = new CompagniaAerea();
            compagnia.AddCitta(new Citta("Roma"));
            compagnia.AddCitta(new Citta("Milano"));
            compagnia.AddCitta(new Citta("Napoli"));
            compagnia.AddAeroporto(new Aeroporto("Aeroporto Roma", "123", compagnia.GetCittas()[0]));
            compagnia.AddAeroporto(new Aeroporto("Aeroporto Milano", "456", compagnia.GetCittas()[1]));
            compagnia.AddAeroporto(new Aeroporto("Aeroporto Napoli", "789", compagnia.GetCittas()[2]));
            compagnia.AddAeromobile(new Aeromobile("123", "737", "Boeing", DateTime.MinValue));
            compagnia.AddAeromobile(new Aeromobile("456", "A320", "Airbus", DateTime.MinValue));
            compagnia.AddAeromobile(new Aeromobile("789", "777", "Boeing", DateTime.MinValue));
            compagnia.AddPilota(new Pilota("Mario", "Rossi", DateTime.MinValue, "1° banda dorata"));
            compagnia.AddPilota(new Pilota("Luigi", "Verdi", DateTime.MinValue, "2° banda dorata"));
            compagnia.AddPilota(new Pilota("Marco", "Bianchi", DateTime.MinValue, "3° banda dorata"));
            compagnia.AddAssistente(new Assistente("Luca", "Russo", DateTime.MinValue, "Semplice"));
            compagnia.AddAssistente(new Assistente("Chiara", "Ferrari", DateTime.MinValue, "Responsabile"));
            compagnia.AddAssistente(new Assistente("Anna", "Ricci", DateTime.MinValue, "Capo cabina"));
            compagnia.AddVolo(new Volo("123", DateTime.Now.TimeOfDay, DateTime.Now.TimeOfDay, compagnia.GetAeroporti()[0], compagnia.GetAeroporti()[1]));
            compagnia.AddVolo(new Volo("456", DateTime.Now.TimeOfDay, DateTime.Now.TimeOfDay, compagnia.GetAeroporti()[1], compagnia.GetAeroporti()[2]));
            compagnia.AddVolo(new Volo("789", DateTime.Now.TimeOfDay, DateTime.Now.TimeOfDay, compagnia.GetAeroporti()[2], compagnia.GetAeroporti()[0]));
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
