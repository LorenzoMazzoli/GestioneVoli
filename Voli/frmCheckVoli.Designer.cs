
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
            this.radlblVoli = new Telerik.WinControls.UI.RadLabel();
            this.btnRemoveVolo = new System.Windows.Forms.Button();
            this.lbCheckVoli = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.radlblVoli)).BeginInit();
            this.SuspendLayout();
            // 
            // radlblVoli
            // 
            this.radlblVoli.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radlblVoli.Location = new System.Drawing.Point(159, 29);
            this.radlblVoli.Name = "radlblVoli";
            this.radlblVoli.Size = new System.Drawing.Size(283, 41);
            this.radlblVoli.TabIndex = 1;
            this.radlblVoli.Text = "Voli della compagnia";
            this.radlblVoli.ThemeName = "Fluent";
            // 
            // btnRemoveVolo
            // 
            this.btnRemoveVolo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveVolo.Location = new System.Drawing.Point(12, 91);
            this.btnRemoveVolo.Name = "btnRemoveVolo";
            this.btnRemoveVolo.Size = new System.Drawing.Size(143, 63);
            this.btnRemoveVolo.TabIndex = 0;
            this.btnRemoveVolo.Text = "Rimuovi Volo";
            this.btnRemoveVolo.UseVisualStyleBackColor = true;
            this.btnRemoveVolo.Click += new System.EventHandler(this.btnRemoveVolo_Click);
            // 
            // lbCheckVoli
            // 
            this.lbCheckVoli.FormattingEnabled = true;
            this.lbCheckVoli.ItemHeight = 20;
            this.lbCheckVoli.Location = new System.Drawing.Point(161, 91);
            this.lbCheckVoli.Name = "lbCheckVoli";
            this.lbCheckVoli.Size = new System.Drawing.Size(836, 244);
            this.lbCheckVoli.TabIndex = 2;
            // 
            // frmCheckVoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 357);
            this.Controls.Add(this.lbCheckVoli);
            this.Controls.Add(this.btnRemoveVolo);
            this.Controls.Add(this.radlblVoli);
            this.Name = "frmCheckVoli";
            this.Text = "frmCheckVoli";
            this.Load += new System.EventHandler(this.frmCheckVoli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radlblVoli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel radlblVoli;
        private System.Windows.Forms.Button btnRemoveVolo;
        private System.Windows.Forms.ListBox lbCheckVoli;
    }
}