
namespace Voli
{
    partial class frmVoli
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
            this.btnAggiungiVolo = new System.Windows.Forms.Button();
            this.btnCheckVoli = new System.Windows.Forms.Button();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAggiungiVolo
            // 
            this.btnAggiungiVolo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAggiungiVolo.Location = new System.Drawing.Point(289, 64);
            this.btnAggiungiVolo.Name = "btnAggiungiVolo";
            this.btnAggiungiVolo.Size = new System.Drawing.Size(176, 63);
            this.btnAggiungiVolo.TabIndex = 0;
            this.btnAggiungiVolo.Text = "Aggiungi Volo";
            this.btnAggiungiVolo.UseVisualStyleBackColor = true;
            this.btnAggiungiVolo.Click += new System.EventHandler(this.btnAggiungiVolo_Click);
            // 
            // btnCheckVoli
            // 
            this.btnCheckVoli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckVoli.Location = new System.Drawing.Point(289, 193);
            this.btnCheckVoli.Name = "btnCheckVoli";
            this.btnCheckVoli.Size = new System.Drawing.Size(176, 63);
            this.btnCheckVoli.TabIndex = 1;
            this.btnCheckVoli.Text = "Controlla Lista Voli";
            this.btnCheckVoli.UseVisualStyleBackColor = true;
            this.btnCheckVoli.Click += new System.EventHandler(this.btnCheckVoli_Click);
            // 
            // btnChiudi
            // 
            this.btnChiudi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChiudi.Location = new System.Drawing.Point(320, 339);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(107, 43);
            this.btnChiudi.TabIndex = 2;
            this.btnChiudi.Text = "Chiudi";
            this.btnChiudi.UseVisualStyleBackColor = true;
            // 
            // frmVoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.btnCheckVoli);
            this.Controls.Add(this.btnAggiungiVolo);
            this.Name = "frmVoli";
            this.Text = "frmVoli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungiVolo;
        private System.Windows.Forms.Button btnCheckVoli;
        private System.Windows.Forms.Button btnChiudi;
    }
}