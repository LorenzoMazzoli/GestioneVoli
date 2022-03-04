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
    }
}
