﻿
namespace Voli
{
    partial class frmViaggio
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
            this.radlcVoli = new Telerik.WinControls.UI.RadListControl();
            ((System.ComponentModel.ISupportInitialize)(this.radlcVoli)).BeginInit();
            this.SuspendLayout();
            // 
            // radlcVoli
            // 
            this.radlcVoli.Location = new System.Drawing.Point(12, 37);
            this.radlcVoli.Name = "radlcVoli";
            this.radlcVoli.Size = new System.Drawing.Size(776, 401);
            this.radlcVoli.TabIndex = 0;
            // 
            // frmViaggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radlcVoli);
            this.Name = "frmViaggio";
            this.Text = "frmViaggio";
            this.Load += new System.EventHandler(this.frmViaggio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radlcVoli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListControl radlcVoli;
    }
}