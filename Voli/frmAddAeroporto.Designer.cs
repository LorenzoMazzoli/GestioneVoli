
namespace Voli
{
    partial class frmAddAeroporto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbCodice = new System.Windows.Forms.TextBox();
            this.cmbCitta = new System.Windows.Forms.ComboBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(111, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(105, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(53, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Città di appartenza";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(253, 60);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(125, 27);
            this.txbNome.TabIndex = 3;
            // 
            // txbCodice
            // 
            this.txbCodice.Location = new System.Drawing.Point(253, 109);
            this.txbCodice.Name = "txbCodice";
            this.txbCodice.Size = new System.Drawing.Size(125, 27);
            this.txbCodice.TabIndex = 4;
            // 
            // cmbCitta
            // 
            this.cmbCitta.FormattingEnabled = true;
            this.cmbCitta.Location = new System.Drawing.Point(253, 158);
            this.cmbCitta.Name = "cmbCitta";
            this.cmbCitta.Size = new System.Drawing.Size(151, 28);
            this.cmbCitta.TabIndex = 5;
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalva.Location = new System.Drawing.Point(86, 275);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(94, 49);
            this.btnSalva.TabIndex = 6;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnChiudi
            // 
            this.btnChiudi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChiudi.Location = new System.Drawing.Point(253, 275);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(94, 49);
            this.btnChiudi.TabIndex = 7;
            this.btnChiudi.Text = "Chiudi";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // frmAddAeroporto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 377);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.cmbCitta);
            this.Controls.Add(this.txbCodice);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddAeroporto";
            this.Text = "frmAddAeroporto";
            this.Load += new System.EventHandler(this.frmAddAeroporto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbCodice;
        private System.Windows.Forms.ComboBox cmbCitta;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnChiudi;
    }
}