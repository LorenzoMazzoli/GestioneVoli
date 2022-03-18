
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddViaggio = new System.Windows.Forms.Button();
            this.btnRemoveViaggio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radlcVoli)).BeginInit();
            this.SuspendLayout();
            // 
            // radlcVoli
            // 
            this.radlcVoli.Location = new System.Drawing.Point(219, 87);
            this.radlcVoli.Name = "radlcVoli";
            this.radlcVoli.Size = new System.Drawing.Size(1349, 401);
            this.radlcVoli.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(484, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Viaggi della compagnia";
            // 
            // btnAddViaggio
            // 
            this.btnAddViaggio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddViaggio.Location = new System.Drawing.Point(12, 105);
            this.btnAddViaggio.Name = "btnAddViaggio";
            this.btnAddViaggio.Size = new System.Drawing.Size(201, 64);
            this.btnAddViaggio.TabIndex = 0;
            this.btnAddViaggio.Text = "Aggiungi viaggio";
            this.btnAddViaggio.UseVisualStyleBackColor = true;
            this.btnAddViaggio.Click += new System.EventHandler(this.btnAddViaggio_Click);
            // 
            // btnRemoveViaggio
            // 
            this.btnRemoveViaggio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveViaggio.Location = new System.Drawing.Point(12, 198);
            this.btnRemoveViaggio.Name = "btnRemoveViaggio";
            this.btnRemoveViaggio.Size = new System.Drawing.Size(201, 64);
            this.btnRemoveViaggio.TabIndex = 1;
            this.btnRemoveViaggio.Text = "Rimuovi viaggio";
            this.btnRemoveViaggio.UseVisualStyleBackColor = true;
            this.btnRemoveViaggio.Click += new System.EventHandler(this.btnRemoveViaggio_Click);
            // 
            // frmViaggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 500);
            this.Controls.Add(this.btnRemoveViaggio);
            this.Controls.Add(this.btnAddViaggio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radlcVoli);
            this.Name = "frmViaggio";
            this.Text = "frmViaggio";
            this.Load += new System.EventHandler(this.frmViaggio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radlcVoli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadListControl radlcVoli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddViaggio;
        private System.Windows.Forms.Button btnRemoveViaggio;
    }
}