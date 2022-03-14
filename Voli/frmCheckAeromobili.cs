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
    public partial class frmCheckAeromobili : Form
    {
        List<Aeromobile> aeromobili;
        public frmCheckAeromobili(List<Aeromobile> aeromobili)
        {
            InitializeComponent();
            this.aeromobili = aeromobili;
        }

        private void frmCheckAeromobili_Load(object sender, EventArgs e)
        {
            foreach (Aeromobile a in aeromobili)
            {
                lbCheckAeromobili.Items.Add(a.GetInfo());
            }
        }

        private void btnRemoveAeromobile_Click(object sender, EventArgs e)
        {
            if (lbCheckAeromobili.SelectedItem == null)
            {
                MessageBox.Show("Selezionare prima un aeromobile");
            }
            else
            {
                try
                {
                    Aeromobile a = aeromobili.First(a => lbCheckAeromobili.SelectedItem.ToString() == a.GetInfo());
                    aeromobili.Remove(a);
                }
                catch (Exception)
                {

                    throw;
                }

                lbCheckAeromobili.Items.Clear();
                foreach (Aeromobile aeromobile in aeromobili)
                {
                    lbCheckAeromobili.Items.Add(aeromobile.GetInfo());
                }
            }
        }
    }
}
