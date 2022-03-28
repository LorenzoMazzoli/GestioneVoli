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
    public partial class frmCheckPersonale : Form
    {
        List<Pilota> piloti;
        List<Assistente> assistenti;
        public frmCheckPersonale(List<Pilota> piloti, List<Assistente> assistenti)
        {
            InitializeComponent();
            this.piloti = piloti;
            this.assistenti = assistenti;
        }

        private void frmCheckPersonale_Load(object sender, EventArgs e)
        {
            btnRemoveAssistente.Visible = false;
            btnRemovePilota.Visible = false;
            cmbTipoPersonale.Text = " Selezionare personale";
        }

        private void cmbTipoPersonale_SelectedIndexChanged(object sender, EventArgs e)
        {
            // In base alla scritta presente nel combobox, compilo la listbox, con piloti oppure assistenti
            if ((string)cmbTipoPersonale.SelectedItem == "Piloti")
            {
                lbCheckPersonale.Items.Clear();
                foreach (Pilota p in piloti)
                {
                    lbCheckPersonale.Items.Add(p.GetInfo());
                }

                btnRemoveAssistente.Visible = false;
                btnRemovePilota.Visible = true;
            }
            if ((string)cmbTipoPersonale.SelectedItem == "Assistenti")
            {
                lbCheckPersonale.Items.Clear();
                foreach (Assistente a in assistenti)
                {
                    lbCheckPersonale.Items.Add(a.GetInfo());
                }

                btnRemoveAssistente.Visible = true;
                btnRemovePilota.Visible = false;
            }
        }

        private void btnRemovePilota_Click(object sender, EventArgs e)
        {
            if (lbCheckPersonale.SelectedItem == null)
            {
                MessageBox.Show("Selezionare prima un pilota");
            }
            else
            {
                try
                {
                    Pilota pilota = piloti.First(pilota => lbCheckPersonale.SelectedItem.ToString() == pilota.GetInfo());
                    piloti.Remove(pilota);
                }
                catch (Exception)
                {

                    throw;
                }

                lbCheckPersonale.Items.Clear();
                foreach (Pilota pilota in piloti)
                {
                    lbCheckPersonale.Items.Add(pilota.GetInfo());
                }
            }
        }

        private void btnRemoveAssistente_Click(object sender, EventArgs e)
        {
            if (lbCheckPersonale.SelectedItem == null)
            {
                MessageBox.Show("Selezionare prima un assistente");
            }
            else
            {
                try
                {
                    Assistente assistente = assistenti.First(assistente => lbCheckPersonale.SelectedItem.ToString() == assistente.GetInfo());
                    assistenti.Remove(assistente);
                }
                catch (Exception)
                {

                    throw;
                }

                lbCheckPersonale.Items.Clear();
                foreach (Assistente assistente in assistenti)
                {
                    lbCheckPersonale.Items.Add(assistente.GetInfo());
                }
            }
        }
    }
}
