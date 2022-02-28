
namespace Voli
{
    partial class frmPersonale
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
            this.btnPilota = new System.Windows.Forms.Button();
            this.btnAssistente = new System.Windows.Forms.Button();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPilota
            // 
            this.btnPilota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPilota.Location = new System.Drawing.Point(299, 84);
            this.btnPilota.Name = "btnPilota";
            this.btnPilota.Size = new System.Drawing.Size(182, 60);
            this.btnPilota.TabIndex = 0;
            this.btnPilota.Text = "Pilota";
            this.btnPilota.UseVisualStyleBackColor = true;
            this.btnPilota.Click += new System.EventHandler(this.btnPilota_Click);
            // 
            // btnAssistente
            // 
            this.btnAssistente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAssistente.Location = new System.Drawing.Point(299, 195);
            this.btnAssistente.Name = "btnAssistente";
            this.btnAssistente.Size = new System.Drawing.Size(182, 60);
            this.btnAssistente.TabIndex = 1;
            this.btnAssistente.Text = "Assistente";
            this.btnAssistente.UseVisualStyleBackColor = true;
            this.btnAssistente.Click += new System.EventHandler(this.btnAssistente_Click);
            // 
            // btnChiudi
            // 
            this.btnChiudi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChiudi.Location = new System.Drawing.Point(352, 333);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(80, 35);
            this.btnChiudi.TabIndex = 2;
            this.btnChiudi.Text = "Chiudi";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // frmPersonale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.btnAssistente);
            this.Controls.Add(this.btnPilota);
            this.Name = "frmPersonale";
            this.Text = "frmPersonale";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPilota;
        private System.Windows.Forms.Button btnAssistente;
        private System.Windows.Forms.Button btnChiudi;
    }
}