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
using Telerik;

namespace Voli
{
    public partial class frmViaggio : Form
    {
        CompagniaAerea compagnia = new CompagniaAerea();
        public frmViaggio(CompagniaAerea compagnia)
        {
            InitializeComponent();
            this.compagnia = compagnia;
        }

        private void frmViaggio_Load(object sender, EventArgs e)
        {
            foreach (Viaggio v in compagnia.GetViaggi())
            {
                radlcViaggi.Items.Add(v.GetInfo());
            }
            foreach  (Aeroporto a in compagnia.GetAeroporti())
            {
                cmbAeroporti.Items.Add(a.GetNome());
            }
        }

        private void btnAddViaggio_Click(object sender, EventArgs e)
        {
            frmAddViaggio FormAddViaggio = new frmAddViaggio(compagnia);

            FormAddViaggio.ShowDialog();

            compagnia.AddViaggio(new Viaggio(FormAddViaggio.GetGiorno(), FormAddViaggio.GetPilota(), FormAddViaggio.GetCopilota(), FormAddViaggio.GetAssistenti(), FormAddViaggio.GetVolo()));
            
            radlcViaggi.Items.Clear();
            foreach (Viaggio v in compagnia.GetViaggi())
            {
                radlcViaggi.Items.Add(v.GetInfo());
            }
        }

        private void btnRemoveViaggio_Click(object sender, EventArgs e)
        {
            if (radlcViaggi.SelectedItem==null)
            {
                MessageBox.Show("Selezionare prima un viaggio");
            }
            else
            {
                try
                {
                    Viaggio v = compagnia.GetViaggi().First(v => radlcViaggi.SelectedItem.ToString() == v.GetInfo());
                    compagnia.GetViaggi().Remove(v);
                }
                catch (Exception)
                {

                    throw;
                }

                radlcViaggi.Items.Clear();
                foreach (Viaggio v in compagnia.GetViaggi())
                {
                    radlcViaggi.Items.Add(v.GetInfo());
                }
            }
            
        }

        private void cmbAeroporti_SelectedIndexChanged(object sender, EventArgs e)
        {
            radlcViaggi.Items.Clear();
            foreach (Viaggio v in compagnia.GetViaggi())
            {
                if (cmbAeroporti.Text == v.GetVolo().GetNomeAeroportoPartenza())
                {
                    radlcViaggi.Items.Add(v.GetInfo());
                }
            }
        }
    }
}
