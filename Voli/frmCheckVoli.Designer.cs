
namespace Voli
{
    partial class frmCheckVoli
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
            this.rlcCheckVoli = new Telerik.WinControls.UI.RadListControl();
            this.radlblVoli = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.rlcCheckVoli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radlblVoli)).BeginInit();
            this.SuspendLayout();
            // 
            // rlcCheckVoli
            // 
            this.rlcCheckVoli.Location = new System.Drawing.Point(12, 91);
            this.rlcCheckVoli.Name = "rlcCheckVoli";
            this.rlcCheckVoli.Size = new System.Drawing.Size(776, 347);
            this.rlcCheckVoli.TabIndex = 0;
            // 
            // radlblVoli
            // 
            this.radlblVoli.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radlblVoli.Location = new System.Drawing.Point(266, 27);
            this.radlblVoli.Name = "radlblVoli";
            this.radlblVoli.Size = new System.Drawing.Size(283, 41);
            this.radlblVoli.TabIndex = 1;
            this.radlblVoli.Text = "Voli della compagnia";
            this.radlblVoli.ThemeName = "Fluent";
            // 
            // frmCheckVoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radlblVoli);
            this.Controls.Add(this.rlcCheckVoli);
            this.Name = "frmCheckVoli";
            this.Text = "frmCheckVoli";
            this.Load += new System.EventHandler(this.frmCheckVoli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rlcCheckVoli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radlblVoli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadListControl rlcCheckVoli;
        private Telerik.WinControls.UI.RadLabel radlblVoli;
    }
}