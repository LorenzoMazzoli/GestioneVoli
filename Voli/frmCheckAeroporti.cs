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
    public partial class frmCheckAeroporti : Form
    {
        List<Aeroporto> aeroporti;
        public frmCheckAeroporti(List<Aeroporto> aeroporti)
        {
            InitializeComponent();
            this.aeroporti = aeroporti;
        }

        private void frmCheckAeroporti_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < aeroporti.Count ; i++)
            {
                lbCheckAeroporti.Items.Add(aeroporti[i].GetInfo());
            }
        }

        private void btnRemoveAeroporto_Click(object sender, EventArgs e)
        {
            if (lbCheckAeroporti.SelectedItem == null)
            {
                MessageBox.Show("Selezionare prima un aeroporto");
            }
            else
            {
                try
                {
                    Aeroporto a = aeroporti.First(a => lbCheckAeroporti.SelectedItem.ToString() == a.GetInfo());
                    aeroporti.Remove(a);
                }
                catch (Exception)
                {

                    throw;
                }

                lbCheckAeroporti.Items.Clear();
                foreach (Aeroporto aeroporto in aeroporti)
                {
                    lbCheckAeroporti.Items.Add(aeroporto.GetInfo());
                }
            }
        }
    }
}
