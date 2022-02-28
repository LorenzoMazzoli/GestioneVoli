
namespace Voli
{
    partial class frmComponenti
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
            this.btnVoli = new System.Windows.Forms.Button();
            this.btnAeromobili = new System.Windows.Forms.Button();
            this.btnAeroporti = new System.Windows.Forms.Button();
            this.btnPersonale = new System.Windows.Forms.Button();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoli
            // 
            this.btnVoli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoli.Location = new System.Drawing.Point(282, 25);
            this.btnVoli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVoli.Name = "btnVoli";
            this.btnVoli.Size = new System.Drawing.Size(230, 67);
            this.btnVoli.TabIndex = 0;
            this.btnVoli.Text = "Voli";
            this.btnVoli.UseVisualStyleBackColor = true;
            this.btnVoli.Click += new System.EventHandler(this.btnVoli_Click);
            // 
            // btnAeromobili
            // 
            this.btnAeromobili.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAeromobili.Location = new System.Drawing.Point(12, 274);
            this.btnAeromobili.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAeromobili.Name = "btnAeromobili";
            this.btnAeromobili.Size = new System.Drawing.Size(218, 79);
            this.btnAeromobili.TabIndex = 1;
            this.btnAeromobili.Text = "Aeromobili";
            this.btnAeromobili.UseVisualStyleBackColor = true;
            this.btnAeromobili.Click += new System.EventHandler(this.btnAeromobili_Click);
            // 
            // btnAeroporti
            // 
            this.btnAeroporti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAeroporti.Location = new System.Drawing.Point(12, 100);
            this.btnAeroporti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAeroporti.Name = "btnAeroporti";
            this.btnAeroporti.Size = new System.Drawing.Size(218, 79);
            this.btnAeroporti.TabIndex = 2;
            this.btnAeroporti.Text = "Aeroporti";
            this.btnAeroporti.UseVisualStyleBackColor = true;
            this.btnAeroporti.Click += new System.EventHandler(this.btnAeroporti_Click);
            // 
            // btnPersonale
            // 
            this.btnPersonale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPersonale.Location = new System.Drawing.Point(12, 187);
            this.btnPersonale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPersonale.Name = "btnPersonale";
            this.btnPersonale.Size = new System.Drawing.Size(218, 79);
            this.btnPersonale.TabIndex = 3;
            this.btnPersonale.Text = "Personale";
            this.btnPersonale.UseVisualStyleBackColor = true;
            this.btnPersonale.Click += new System.EventHandler(this.btnPersonale_Click);
            // 
            // btnChiudi
            // 
            this.btnChiudi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChiudi.Location = new System.Drawing.Point(426, 458);
            this.btnChiudi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(110, 61);
            this.btnChiudi.TabIndex = 4;
            this.btnChiudi.Text = "Chiudi";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 67);
            this.label1.TabIndex = 5;
            this.label1.Text = "Voli";
            // 
            // frmComponenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.btnPersonale);
            this.Controls.Add(this.btnAeroporti);
            this.Controls.Add(this.btnAeromobili);
            this.Controls.Add(this.btnVoli);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmComponenti";
            this.Text = "Aggiungi Componenti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoli;
        private System.Windows.Forms.Button btnAeromobili;
        private System.Windows.Forms.Button btnAeroporti;
        private System.Windows.Forms.Button btnPersonale;
        private System.Windows.Forms.Button btnChiudi;
        private System.Windows.Forms.Label label1;
    }
}