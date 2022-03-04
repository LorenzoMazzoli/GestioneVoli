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
    public partial class frmAddAeroporto : Form
    {
        string Nome { get; set; }
        string Codice { get; set; }
        Citta city { get; set; }

        List<string> ListaNomiCitta = new List<string>();
        List<Citta> ListaCitta = new List<Citta>();
        public frmAddAeroporto(List<Citta> ListaCitta)
        {
            InitializeComponent();

            foreach (Citta citta in ListaCitta)
            {
                this.ListaCitta.Add(citta);
                ListaNomiCitta.Add(citta.GetNome());
            }
            
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            /*foreach (string citta in ListaNomiCitta)
            {
                if (cmbCitta.SelectedItem.ToString()=)
                {

                }
            }
            city = (Citta)cmbCitta.SelectedItem;*/
            Close();
        }

        private void frmAddAeroporto_Load(object sender, EventArgs e)
        {
            cmbCitta.DataSource = ListaNomiCitta;
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public string GetCodice()
        {
            return this.Codice;
        }

        public Citta GetCitta()
        {
            return city;
        }

        public string GetNomeCitta()
        {
            return city.GetNome();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            Nome = txbNome.Text;
            Codice = txbCodice.Text;
            foreach (Citta c in ListaCitta)
            {
                if (c.GetNome()==(string)cmbCitta.SelectedItem)
                {
                    city = c;
                }
            }
        }
    }
}
