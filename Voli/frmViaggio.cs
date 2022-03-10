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
                radlcVoli.Items.Add(v.GetInfo());
            }
        }
    }
}
