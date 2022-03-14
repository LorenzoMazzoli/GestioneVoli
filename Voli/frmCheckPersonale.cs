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

                
            }
            if ((string)cmbTipoPersonale.SelectedItem == "Assistenti")
            {
                lbCheckPersonale.Items.Clear();
                foreach (Assistente a in assistenti)
                {
                    lbCheckPersonale.Items.Add(a.GetInfo());
                }
            }
        }
    }
}
