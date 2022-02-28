
namespace Voli
{
    partial class frmAeromobili
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
            this.btnAddAeromobile = new System.Windows.Forms.Button();
            this.btnCheckAeromobile = new System.Windows.Forms.Button();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAeromobile
            // 
            this.btnAddAeromobile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddAeromobile.Location = new System.Drawing.Point(269, 73);
            this.btnAddAeromobile.Name = "btnAddAeromobile";
            this.btnAddAeromobile.Size = new System.Drawing.Size(221, 49);
            this.btnAddAeromobile.TabIndex = 0;
            this.btnAddAeromobile.Text = "Aggiungi Aeromobile";
            this.btnAddAeromobile.UseVisualStyleBackColor = true;
            this.btnAddAeromobile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCheckAeromobile
            // 
            this.btnCheckAeromobile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckAeromobile.Location = new System.Drawing.Point(269, 193);
            this.btnCheckAeromobile.Name = "btnCheckAeromobile";
            this.btnCheckAeromobile.Size = new System.Drawing.Size(221, 49);
            this.btnCheckAeromobile.TabIndex = 1;
            this.btnCheckAeromobile.Text = "Controlla Lista Aeromobili";
            this.btnCheckAeromobile.UseVisualStyleBackColor = true;
            this.btnCheckAeromobile.Click += new System.EventHandler(this.btnCheckAeromobile_Click);
            // 
            // btnChiudi
            // 
            this.btnChiudi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChiudi.Location = new System.Drawing.Point(343, 317);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(81, 41);
            this.btnChiudi.TabIndex = 2;
            this.btnChiudi.Text = "Chiudi";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // frmAeromobili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.btnCheckAeromobile);
            this.Controls.Add(this.btnAddAeromobile);
            this.Name = "frmAeromobili";
            this.Text = "frmAeromobili";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAeromobile;
        private System.Windows.Forms.Button btnCheckAeromobile;
        private System.Windows.Forms.Button btnChiudi;
    }
}