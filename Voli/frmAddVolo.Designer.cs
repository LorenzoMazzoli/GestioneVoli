
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
            this.lblOraPartenza = new System.Windows.Forms.Label();
            this.lblMinutiPartenza = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAeroportoPartenza = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAeroportoArrivo = new System.Windows.Forms.ComboBox();
            this.lblOraArrivo = new System.Windows.Forms.Label();
            this.lblMinutiArrivo = new System.Windows.Forms.Label();
            this.cmbOraArrivo = new System.Windows.Forms.ComboBox();
            this.cmbMinutiPartenza = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 23);
            this.textBox1.TabIndex = 0;
            // 
            // lblCodiceVolo
            // 
            this.lblCodiceVolo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodiceVolo.Location = new System.Drawing.Point(104, 50);
            this.lblCodiceVolo.Name = "lblCodiceVolo";
            this.lblCodiceVolo.Size = new System.Drawing.Size(120, 23);
            this.lblCodiceVolo.TabIndex = 1;
            this.lblCodiceVolo.Text = "Codice Volo";
            this.lblCodiceVolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalva.Location = new System.Drawing.Point(200, 369);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(87, 38);
            this.btnSalva.TabIndex = 2;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            // 
            // btnChiudi
            // 
            this.btnChiudi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChiudi.Location = new System.Drawing.Point(349, 369);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(87, 38);
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
            this.cmbOra.Location = new System.Drawing.Point(60, 147);
            this.cmbOra.Name = "cmbOra";
            this.cmbOra.Size = new System.Drawing.Size(121, 23);
            this.cmbOra.TabIndex = 4;
            // 
            // cmbMinuti
            // 
            this.cmbMinuti.FormattingEnabled = true;
            this.cmbMinuti.Location = new System.Drawing.Point(213, 147);
            this.cmbMinuti.Name = "cmbMinuti";
            this.cmbMinuti.Size = new System.Drawing.Size(121, 23);
            this.cmbMinuti.TabIndex = 5;
            // 
            // lblOraPartenza
            // 
            this.lblOraPartenza.Location = new System.Drawing.Point(71, 114);
            this.lblOraPartenza.Name = "lblOraPartenza";
            this.lblOraPartenza.Size = new System.Drawing.Size(100, 23);
            this.lblOraPartenza.TabIndex = 6;
            this.lblOraPartenza.Text = "Ora Partenza";
            this.lblOraPartenza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutiPartenza
            // 
            this.lblMinutiPartenza.Location = new System.Drawing.Point(222, 114);
            this.lblMinutiPartenza.Name = "lblMinutiPartenza";
            this.lblMinutiPartenza.Size = new System.Drawing.Size(100, 23);
            this.lblMinutiPartenza.TabIndex = 7;
            this.lblMinutiPartenza.Text = "Minuti Partenza";
            this.lblMinutiPartenza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // lblAeroportoPartenza
            // 
            this.lblAeroportoPartenza.Location = new System.Drawing.Point(60, 199);
            this.lblAeroportoPartenza.Name = "lblAeroportoPartenza";
            this.lblAeroportoPartenza.Size = new System.Drawing.Size(126, 26);
            this.lblAeroportoPartenza.TabIndex = 9;
            this.lblAeroportoPartenza.Text = "Aeroporto Partenza";
            this.lblAeroportoPartenza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(213, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Aeroporto Arrivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbAeroportoArrivo
            // 
            this.cmbAeroportoArrivo.FormattingEnabled = true;
            this.cmbAeroportoArrivo.Location = new System.Drawing.Point(222, 239);
            this.cmbAeroportoArrivo.Name = "cmbAeroportoArrivo";
            this.cmbAeroportoArrivo.Size = new System.Drawing.Size(121, 23);
            this.cmbAeroportoArrivo.TabIndex = 11;
            // 
            // lblOraArrivo
            // 
            this.lblOraArrivo.Location = new System.Drawing.Point(446, 114);
            this.lblOraArrivo.Name = "lblOraArrivo";
            this.lblOraArrivo.Size = new System.Drawing.Size(100, 23);
            this.lblOraArrivo.TabIndex = 12;
            this.lblOraArrivo.Text = "Ora Arrivo";
            this.lblOraArrivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutiArrivo
            // 
            this.lblMinutiArrivo.Location = new System.Drawing.Point(616, 114);
            this.lblMinutiArrivo.Name = "lblMinutiArrivo";
            this.lblMinutiArrivo.Size = new System.Drawing.Size(100, 23);
            this.lblMinutiArrivo.TabIndex = 13;
            this.lblMinutiArrivo.Text = "Minuti Partenza";
            this.lblMinutiArrivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cmbOraArrivo.Location = new System.Drawing.Point(425, 147);
            this.cmbOraArrivo.Name = "cmbOraArrivo";
            this.cmbOraArrivo.Size = new System.Drawing.Size(121, 23);
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
            "23"});
            this.cmbMinutiPartenza.Location = new System.Drawing.Point(595, 147);
            this.cmbMinutiPartenza.Name = "cmbMinutiPartenza";
            this.cmbMinutiPartenza.Size = new System.Drawing.Size(121, 23);
            this.cmbMinutiPartenza.TabIndex = 15;
            // 
            // frmAddVolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbMinutiPartenza);
            this.Controls.Add(this.cmbOraArrivo);
            this.Controls.Add(this.lblMinutiArrivo);
            this.Controls.Add(this.lblOraArrivo);
            this.Controls.Add(this.cmbAeroportoArrivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAeroportoPartenza);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblMinutiPartenza);
            this.Controls.Add(this.lblOraPartenza);
            this.Controls.Add(this.cmbMinuti);
            this.Controls.Add(this.cmbOra);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.lblCodiceVolo);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.Label lblOraPartenza;
        private System.Windows.Forms.Label lblMinutiPartenza;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAeroportoPartenza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAeroportoArrivo;
        private System.Windows.Forms.Label lblOraArrivo;
        private System.Windows.Forms.Label lblMinutiArrivo;
        private System.Windows.Forms.ComboBox cmbOraArrivo;
        private System.Windows.Forms.ComboBox cmbMinutiPartenza;
    }
}