
namespace Voli
{
    partial class frmCheckCitta
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
            this.lbCheckCitta = new System.Windows.Forms.ListBox();
            this.btnRemoveCitta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Città che supportano la compagnia";
            // 
            // lbCheckCitta
            // 
            this.lbCheckCitta.FormattingEnabled = true;
            this.lbCheckCitta.ItemHeight = 20;
            this.lbCheckCitta.Location = new System.Drawing.Point(153, 67);
            this.lbCheckCitta.Name = "lbCheckCitta";
            this.lbCheckCitta.Size = new System.Drawing.Size(238, 164);
            this.lbCheckCitta.TabIndex = 1;
            // 
            // btnRemoveCitta
            // 
            this.btnRemoveCitta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveCitta.Location = new System.Drawing.Point(13, 71);
            this.btnRemoveCitta.Name = "btnRemoveCitta";
            this.btnRemoveCitta.Size = new System.Drawing.Size(123, 42);
            this.btnRemoveCitta.TabIndex = 2;
            this.btnRemoveCitta.Text = "Rimuovi Città";
            this.btnRemoveCitta.UseVisualStyleBackColor = true;
            this.btnRemoveCitta.Click += new System.EventHandler(this.btnRemoveCitta_Click);
            // 
            // frmCheckCitta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 265);
            this.Controls.Add(this.btnRemoveCitta);
            this.Controls.Add(this.lbCheckCitta);
            this.Controls.Add(this.label1);
            this.Name = "frmCheckCitta";
            this.Text = "frmCheckCitta";
            this.Load += new System.EventHandler(this.frmCheckCitta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCheckCitta;
        private System.Windows.Forms.Button btnRemoveCitta;
    }
}