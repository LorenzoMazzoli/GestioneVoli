using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voli
{
    public partial class Form1 : Form
    {
        DateTime d = DateTime.Today;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(d.Hour.ToString() + ":" +  d.Minute.ToString());
            //MessageBox.Show(d.ToString());
        }

        private void btnModificaCompagnia_Click(object sender, EventArgs e)
        {
            frmComponenti formAggiungiComponenti = new frmComponenti();

            formAggiungiComponenti.ShowDialog();
            
        }
    }
}
