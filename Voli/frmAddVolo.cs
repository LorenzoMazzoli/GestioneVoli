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
    public partial class frmAddVolo : Form
    {
        string Codice { get; set; }
        
        public frmAddVolo()
        {
            InitializeComponent();
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddVolo_Load(object sender, EventArgs e)
        {
            /*this.dateTimePicker1.CustomFormat = "HH:mm tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ShowUpDown = true;*/
            /*TimePicker timePicker = new TimePicker(0, false, true);
            var tokens = timePicker.Tokens;
            tokens.Clear();
            timePicker.Mask = "99:99\\ LL";
            timePicker.DateTimeFormat = "hh:mm tt";
            timePicker.Value = timePicker.TextToValue(timePicker.ValueToText(DateTime.Now));
            tokens[0].MinValue = 1;
            tokens[0].MaxValue = 13;
            tokens[2].MaxValue = 60;
            tokens[tokens.Count - 1].CustomValues = new Object[] { "AM", "PM" };*/
        }
    }
}
