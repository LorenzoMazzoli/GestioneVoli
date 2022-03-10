
namespace Voli
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModificaCompagnia = new System.Windows.Forms.Button();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.btnAddViaggio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModificaCompagnia
            // 
            this.btnModificaCompagnia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificaCompagnia.Location = new System.Drawing.Point(154, 148);
            this.btnModificaCompagnia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificaCompagnia.Name = "btnModificaCompagnia";
            this.btnModificaCompagnia.Size = new System.Drawing.Size(243, 60);
            this.btnModificaCompagnia.TabIndex = 0;
            this.btnModificaCompagnia.Text = "Componenti";
            this.btnModificaCompagnia.UseVisualStyleBackColor = true;
            this.btnModificaCompagnia.Click += new System.EventHandler(this.btnModificaCompagnia_Click);
            // 
            // lblTitolo
            // 
            this.lblTitolo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTitolo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitolo.Location = new System.Drawing.Point(92, 36);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(363, 61);
            this.lblTitolo.TabIndex = 1;
            this.lblTitolo.Text = "Compagnia aerea";
            this.lblTitolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddViaggio
            // 
            this.btnAddViaggio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddViaggio.Location = new System.Drawing.Point(154, 259);
            this.btnAddViaggio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddViaggio.Name = "btnAddViaggio";
            this.btnAddViaggio.Size = new System.Drawing.Size(243, 61);
            this.btnAddViaggio.TabIndex = 2;
            this.btnAddViaggio.Text = " Viaggi";
            this.btnAddViaggio.UseVisualStyleBackColor = true;
            this.btnAddViaggio.Click += new System.EventHandler(this.btnAddViaggio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 391);
            this.Controls.Add(this.btnAddViaggio);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.btnModificaCompagnia);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Compagnia Aerea";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificaCompagnia;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Button btnAddViaggio;
    }
}

