﻿
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
            this.lbCheckCitta.Location = new System.Drawing.Point(113, 62);
            this.lbCheckCitta.Name = "lbCheckCitta";
            this.lbCheckCitta.Size = new System.Drawing.Size(238, 164);
            this.lbCheckCitta.TabIndex = 1;
            // 
            // frmCheckCitta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 265);
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
    }
}