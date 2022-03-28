
namespace Voli
{
    partial class frmCheckPersonale
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
            this.cmbTipoPersonale = new System.Windows.Forms.ComboBox();
            this.lbCheckPersonale = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemovePilota = new System.Windows.Forms.Button();
            this.btnRemoveAssistente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(251, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personale della compagnia";
            // 
            // cmbTipoPersonale
            // 
            this.cmbTipoPersonale.FormattingEnabled = true;
            this.cmbTipoPersonale.Items.AddRange(new object[] {
            "Piloti",
            "Assistenti"});
            this.cmbTipoPersonale.Location = new System.Drawing.Point(12, 109);
            this.cmbTipoPersonale.Name = "cmbTipoPersonale";
            this.cmbTipoPersonale.Size = new System.Drawing.Size(182, 28);
            this.cmbTipoPersonale.TabIndex = 1;
            this.cmbTipoPersonale.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPersonale_SelectedIndexChanged);
            // 
            // lbCheckPersonale
            // 
            this.lbCheckPersonale.FormattingEnabled = true;
            this.lbCheckPersonale.ItemHeight = 20;
            this.lbCheckPersonale.Location = new System.Drawing.Point(207, 93);
            this.lbCheckPersonale.Name = "lbCheckPersonale";
            this.lbCheckPersonale.Size = new System.Drawing.Size(717, 344);
            this.lbCheckPersonale.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personale da visualizzare";
            // 
            // btnRemovePilota
            // 
            this.btnRemovePilota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemovePilota.Location = new System.Drawing.Point(12, 190);
            this.btnRemovePilota.Name = "btnRemovePilota";
            this.btnRemovePilota.Size = new System.Drawing.Size(182, 59);
            this.btnRemovePilota.TabIndex = 4;
            this.btnRemovePilota.Text = "Rimuovi Pilota";
            this.btnRemovePilota.UseVisualStyleBackColor = true;
            this.btnRemovePilota.Click += new System.EventHandler(this.btnRemovePilota_Click);
            // 
            // btnRemoveAssistente
            // 
            this.btnRemoveAssistente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveAssistente.Location = new System.Drawing.Point(12, 190);
            this.btnRemoveAssistente.Name = "btnRemoveAssistente";
            this.btnRemoveAssistente.Size = new System.Drawing.Size(182, 59);
            this.btnRemoveAssistente.TabIndex = 5;
            this.btnRemoveAssistente.Text = "Rimuovi Assistente";
            this.btnRemoveAssistente.UseVisualStyleBackColor = true;
            this.btnRemoveAssistente.Click += new System.EventHandler(this.btnRemoveAssistente_Click);
            // 
            // frmCheckPersonale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.btnRemoveAssistente);
            this.Controls.Add(this.btnRemovePilota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCheckPersonale);
            this.Controls.Add(this.cmbTipoPersonale);
            this.Controls.Add(this.label1);
            this.Name = "frmCheckPersonale";
            this.Text = "frmCheckPersonale";
            this.Load += new System.EventHandler(this.frmCheckPersonale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoPersonale;
        private System.Windows.Forms.ListBox lbCheckPersonale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemovePilota;
        private System.Windows.Forms.Button btnRemoveAssistente;
    }
}