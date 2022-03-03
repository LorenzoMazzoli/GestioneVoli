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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnModificaCompagnia_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            frmComponenti formAggiungiComponenti = new frmComponenti();

            formAggiungiComponenti.ShowDialog();
        }
    }
}
