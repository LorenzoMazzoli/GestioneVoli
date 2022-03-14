
namespace Voli
{
    partial class frmAddAeromobile
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
            this.txtMatricola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataAcquisto = new System.Windows.Forms.DateTimePicker();
            this.txtModello = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricola";
            // 
            // txtMatricola
            // 
            this.txtMatricola.Location = new System.Drawing.Point(151, 65);
            this.txtMatricola.Name = "txtMatricola";
            this.txtMatricola.Size = new System.Drawing.Size(125, 27);
            this.txtMatricola.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modello";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(490, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data d\'acquisto";
            // 
            // dtpDataAcquisto
            // 
            this.dtpDataAcquisto.Location = new System.Drawing.Point(457, 113);
            this.dtpDataAcquisto.Name = "dtpDataAcquisto";
            this.dtpDataAcquisto.Size = new System.Drawing.Size(250, 27);
            this.dtpDataAcquisto.TabIndex = 5;
            // 
            // txtModello
            // 
            this.txtModello.Location = new System.Drawing.Point(151, 113);
            this.txtModello.Name = "txtModello";
            this.txtModello.Size = new System.Drawing.Size(125, 27);
            this.txtModello.TabIndex = 6;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(151, 158);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(125, 27);
            this.txtMarca.TabIndex = 7;
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalva.Location = new System.Drawing.Point(81, 292);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(105, 44);
            this.btnSalva.TabIndex = 8;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnChiudi
            // 
            this.btnChiudi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChiudi.Location = new System.Drawing.Point(237, 292);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(105, 44);
            this.btnChiudi.TabIndex = 9;
            this.btnChiudi.Text = "Chiudi";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // frmAddAeromobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModello);
            this.Controls.Add(this.dtpDataAcquisto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatricola);
            this.Controls.Add(this.label1);
            this.Name = "frmAddAeromobile";
            this.Text = "Aggiungi aeromobile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataAcquisto;
        private System.Windows.Forms.TextBox txtModello;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnChiudi;
    }
}