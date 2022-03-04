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
                lbCheckAeroporti.Items.Add("Nome: "+aeroporti[i].GetNome()+ "   Codice: "+aeroporti[i].GetCodice()+ "    Città: " + aeroporti[i].GetNomeCitta());
            }
        }
    }
}
