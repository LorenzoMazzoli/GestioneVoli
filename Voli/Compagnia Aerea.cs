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
    public partial class Form1 : Form
    {
        static CompagniaAerea compagnia = new CompagniaAerea();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            compagnia.AddViaggio(new Viaggio(DateTime.Now, compagnia.GetPiloti()[0], compagnia.GetPiloti()[1], compagnia.GetAssistenti()));
            compagnia.AddViaggio(new Viaggio(DateTime.Now, compagnia.GetPiloti()[1], compagnia.GetPiloti()[2], compagnia.GetAssistenti()));
            compagnia.AddViaggio(new Viaggio(DateTime.Now, compagnia.GetPiloti()[2], compagnia.GetPiloti()[0], compagnia.GetAssistenti()));
        }

        private void btnModificaCompagnia_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            frmComponenti formAggiungiComponenti = new frmComponenti(compagnia);

            formAggiungiComponenti.ShowDialog();
        }

        private void btnAddViaggio_Click(object sender, EventArgs e)
        {
            frmViaggio formViaggio = new frmViaggio(compagnia);

            formViaggio.ShowDialog();
        }
    }
}
