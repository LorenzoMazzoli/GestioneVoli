
namespace Voli
{
    partial class frmAddVolo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCodiceVolo = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.cmbOra = new System.Windows.Forms.ComboBox();
            this.cmbMinuti = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAeroportoPartenza = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAeroportoArrivo = new System.Windows.Forms.ComboBox();
            this.cmbOraArrivo = new System.Windows.Forms.ComboBox();
            this.cmbMinutiPartenza = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 27);
            this.textBox1.TabIndex = 0;
            // 
            // lblCodiceVolo
            // 
            this.lblCodiceVolo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodiceVolo.Location = new System.Drawing.Point(57, 64);
            this.lblCodiceVolo.Name = "lblCodiceVolo";
            this.lblCodiceVolo.Size = new System.Drawing.Size(137, 31);
            this.lblCodiceVolo.TabIndex = 1;
            this.lblCodiceVolo.Text = "Codice Volo";
            this.lblCodiceVolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalva.Location = new System.Drawing.Point(95, 396);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(99, 51);
            this.btnSalva.TabIndex = 2;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            // 
            // btnChiudi
            // 
            this.btnChiudi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChiudi.Location = new System.Drawing.Point(262, 396);
            this.btnChiudi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(99, 51);
            this.btnChiudi.TabIndex = 3;
            this.btnChiudi.Text = "Chiudi";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // cmbOra
            // 
            this.cmbOra.FormattingEnabled = true;
            this.cmbOra.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbOra.Location = new System.Drawing.Point(69, 196);
            this.cmbOra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOra.Name = "cmbOra";
            this.cmbOra.Size = new System.Drawing.Size(54, 28);
            this.cmbOra.TabIndex = 4;
            // 
            // cmbMinuti
            // 
            this.cmbMinuti.FormattingEnabled = true;
            this.cmbMinuti.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMinuti.Location = new System.Drawing.Point(142, 196);
            this.cmbMinuti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMinuti.Name = "cmbMinuti";
            this.cmbMinuti.Size = new System.Drawing.Size(55, 28);
            this.cmbMinuti.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 319);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // lblAeroportoPartenza
            // 
            this.lblAeroportoPartenza.Location = new System.Drawing.Point(69, 265);
            this.lblAeroportoPartenza.Name = "lblAeroportoPartenza";
            this.lblAeroportoPartenza.Size = new System.Drawing.Size(144, 35);
            this.lblAeroportoPartenza.TabIndex = 9;
            this.lblAeroportoPartenza.Text = "Aeroporto Partenza";
            this.lblAeroportoPartenza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(237, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Aeroporto Arrivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbAeroportoArrivo
            // 
            this.cmbAeroportoArrivo.FormattingEnabled = true;
            this.cmbAeroportoArrivo.Location = new System.Drawing.Point(243, 319);
            this.cmbAeroportoArrivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAeroportoArrivo.Name = "cmbAeroportoArrivo";
            this.cmbAeroportoArrivo.Size = new System.Drawing.Size(138, 28);
            this.cmbAeroportoArrivo.TabIndex = 11;
            // 
            // cmbOraArrivo
            // 
            this.cmbOraArrivo.FormattingEnabled = true;
            this.cmbOraArrivo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbOraArrivo.Location = new System.Drawing.Point(255, 199);
            this.cmbOraArrivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOraArrivo.Name = "cmbOraArrivo";
            this.cmbOraArrivo.Size = new System.Drawing.Size(54, 28);
            this.cmbOraArrivo.TabIndex = 14;
            // 
            // cmbMinutiPartenza
            // 
            this.cmbMinutiPartenza.FormattingEnabled = true;
            this.cmbMinutiPartenza.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMinutiPartenza.Location = new System.Drawing.Point(334, 199);
            this.cmbMinutiPartenza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMinutiPartenza.MaxDropDownItems = 1;
            this.cmbMinutiPartenza.Name = "cmbMinutiPartenza";
            this.cmbMinutiPartenza.Size = new System.Drawing.Size(56, 28);
            this.cmbMinutiPartenza.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Orario di Partenza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(129, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Orario di arrivo";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(315, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = ":";
            // 
            // frmAddVolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 480);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMinutiPartenza);
            this.Controls.Add(this.cmbOraArrivo);
            this.Controls.Add(this.cmbAeroportoArrivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAeroportoPartenza);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbMinuti);
            this.Controls.Add(this.cmbOra);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.lblCodiceVolo);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddVolo";
            this.Text = "frmAddVolo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCodiceVolo;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnChiudi;
        private System.Windows.Forms.ComboBox cmbOra;
        private System.Windows.Forms.ComboBox cmbMinuti;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAeroportoPartenza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAeroportoArrivo;
        private System.Windows.Forms.ComboBox cmbOraArrivo;
        private System.Windows.Forms.ComboBox cmbMinutiPartenza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}