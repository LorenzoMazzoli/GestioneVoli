﻿
namespace Voli
{
    partial class frmCheckAeroporti
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
            this.lbCheckAeroporti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCheckAeroporti
            // 
            this.lbCheckAeroporti.FormattingEnabled = true;
            this.lbCheckAeroporti.ItemHeight = 20;
            this.lbCheckAeroporti.Location = new System.Drawing.Point(12, 56);
            this.lbCheckAeroporti.Name = "lbCheckAeroporti";
            this.lbCheckAeroporti.Size = new System.Drawing.Size(431, 144);
            this.lbCheckAeroporti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aeroporti della compagnia";
            // 
            // frmCheckAeroporti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCheckAeroporti);
            this.Name = "frmCheckAeroporti";
            this.Text = "frmCheckAeroporti";
            this.Load += new System.EventHandler(this.frmCheckAeroporti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCheckAeroporti;
        private System.Windows.Forms.Label label1;
    }
}