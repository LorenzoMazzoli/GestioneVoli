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
    public partial class frmCheckCitta : Form
    {
        List<Citta> cittas = new List<Citta>();
        public frmCheckCitta(List<Citta> cittas)
        {
            InitializeComponent();
            this.cittas = cittas;
        }

        private void frmCheckCitta_Load(object sender, EventArgs e)
        {
            foreach (Citta c in cittas)
            {
                lbCheckCitta.Items.Add(c.GetNome());
            }
        }
    }
}
