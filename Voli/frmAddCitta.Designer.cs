
namespace Voli
{
    partial class frmAddCitta
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
            this.lblNomeCitta = new System.Windows.Forms.Label();
            this.txtNomeCitta = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeCitta
            // 
            this.lblNomeCitta.AutoSize = true;
            this.lblNomeCitta.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeCitta.Location = new System.Drawing.Point(78, 77);
            this.lblNomeCitta.Name = "lblNomeCitta";
            this.lblNomeCitta.Size = new System.Drawing.Size(209, 35);
            this.lblNomeCitta.TabIndex = 0;
            this.lblNomeCitta.Text = "Nome della citta";
            // 
            // txtNomeCitta
            // 
            this.txtNomeCitta.Location = new System.Drawing.Point(305, 86);
            this.txtNomeCitta.Name = "txtNomeCitta";
            this.txtNomeCitta.Size = new System.Drawing.Size(136, 27);
            this.txtNomeCitta.TabIndex = 1;
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalva.Location = new System.Drawing.Point(133, 172);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(94, 58);
            this.btnSalva.TabIndex = 2;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnChiudi
            // 
            this.btnChiudi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChiudi.Location = new System.Drawing.Point(305, 172);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(107, 58);
            this.btnChiudi.TabIndex = 3;
            this.btnChiudi.Text = "Chiudi";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // frmAddCitta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 268);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txtNomeCitta);
            this.Controls.Add(this.lblNomeCitta);
            this.Name = "frmAddCitta";
            this.Text = "frmAddCitta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCitta;
        private System.Windows.Forms.TextBox txtNomeCitta;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnChiudi;
    }
}