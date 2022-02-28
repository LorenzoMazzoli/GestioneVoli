
namespace Voli
{
    partial class frmAeroporti
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
            this.btnAggiungiAeroporto = new System.Windows.Forms.Button();
            this.btnCheckAeroporti = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAggiungiAeroporto
            // 
            this.btnAggiungiAeroporto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAggiungiAeroporto.Location = new System.Drawing.Point(321, 86);
            this.btnAggiungiAeroporto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAggiungiAeroporto.Name = "btnAggiungiAeroporto";
            this.btnAggiungiAeroporto.Size = new System.Drawing.Size(278, 67);
            this.btnAggiungiAeroporto.TabIndex = 0;
            this.btnAggiungiAeroporto.Text = "Aggiungi Aeroporto";
            this.btnAggiungiAeroporto.UseVisualStyleBackColor = true;
            this.btnAggiungiAeroporto.Click += new System.EventHandler(this.btnAggiungiAeroporto_Click);
            // 
            // btnCheckAeroporti
            // 
            this.btnCheckAeroporti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckAeroporti.Location = new System.Drawing.Point(321, 253);
            this.btnCheckAeroporti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckAeroporti.Name = "btnCheckAeroporti";
            this.btnCheckAeroporti.Size = new System.Drawing.Size(278, 67);
            this.btnCheckAeroporti.TabIndex = 1;
            this.btnCheckAeroporti.Text = "Controlla Lista Aeroporti";
            this.btnCheckAeroporti.UseVisualStyleBackColor = true;
            this.btnCheckAeroporti.Click += new System.EventHandler(this.btnCheckAeroporti_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(398, 476);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Chiudi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmAeroporti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCheckAeroporti);
            this.Controls.Add(this.btnAggiungiAeroporto);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAeroporti";
            this.Text = "frmAeroporti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungiAeroporto;
        private System.Windows.Forms.Button btnCheckAeroporti;
        private System.Windows.Forms.Button button1;
    }
}