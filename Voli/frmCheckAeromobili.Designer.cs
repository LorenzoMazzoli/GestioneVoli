
namespace Voli
{
    partial class frmCheckAeromobili
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
            this.lbCheckAeromobili = new System.Windows.Forms.ListBox();
            this.btnRemoveAeromobile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(228, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aeromobili della compagnia";
            // 
            // lbCheckAeromobili
            // 
            this.lbCheckAeromobili.FormattingEnabled = true;
            this.lbCheckAeromobili.ItemHeight = 20;
            this.lbCheckAeromobili.Location = new System.Drawing.Point(209, 74);
            this.lbCheckAeromobili.Name = "lbCheckAeromobili";
            this.lbCheckAeromobili.Size = new System.Drawing.Size(776, 364);
            this.lbCheckAeromobili.TabIndex = 1;
            // 
            // btnRemoveAeromobile
            // 
            this.btnRemoveAeromobile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveAeromobile.Location = new System.Drawing.Point(12, 74);
            this.btnRemoveAeromobile.Name = "btnRemoveAeromobile";
            this.btnRemoveAeromobile.Size = new System.Drawing.Size(177, 64);
            this.btnRemoveAeromobile.TabIndex = 2;
            this.btnRemoveAeromobile.Text = "Rimuovi Aeromobile";
            this.btnRemoveAeromobile.UseVisualStyleBackColor = true;
            this.btnRemoveAeromobile.Click += new System.EventHandler(this.btnRemoveAeromobile_Click);
            // 
            // frmCheckAeromobili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.btnRemoveAeromobile);
            this.Controls.Add(this.lbCheckAeromobili);
            this.Controls.Add(this.label1);
            this.Name = "frmCheckAeromobili";
            this.Text = "frmCheckAeromobili";
            this.Load += new System.EventHandler(this.frmCheckAeromobili_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCheckAeromobili;
        private System.Windows.Forms.Button btnRemoveAeromobile;
    }
}