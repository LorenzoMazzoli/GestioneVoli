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
    public partial class frmCheckVoli : Form
    {
        List<Volo> voli = new List<Volo>();
        public frmCheckVoli(List<Volo> voli)
        {
            InitializeComponent();
            this.voli = voli;
        }

        private void frmCheckVoli_Load(object sender, EventArgs e)
        {
            foreach (Volo v in voli)
            {
                lbCheckVoli.Items.Add(v.GetInfo());
            }
        }

        private void btnRemoveVolo_Click(object sender, EventArgs e)
        {
            if (lbCheckVoli.SelectedItem == null)
            {
                MessageBox.Show("Selezionare prima un volo");
            }
            else
            {
                try
                {
                    Volo volo = voli.First(volo => lbCheckVoli.SelectedItem.ToString() == volo.GetInfo());
                    voli.Remove(volo);
                }
                catch (Exception)
                {

                    throw;
                }

                lbCheckVoli.Items.Clear();
                foreach (Volo volo in voli)
                {
                    lbCheckVoli.Items.Add(volo.GetInfo());
                }
            }
        }
    }
}
