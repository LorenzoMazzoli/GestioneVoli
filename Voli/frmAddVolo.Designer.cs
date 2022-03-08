
namespace Voli
{
    partial class frmAddVolo
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
            this.txtCodiceVolo = new System.Windows.Forms.TextBox();
            this.lblCodiceVolo = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.cmbAeroportiPartenza = new System.Windows.Forms.ComboBox();
            this.lblAeroportoPartenza = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAeroportiArrivo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtmOrarioArrivo = new Telerik.WinControls.UI.RadTimePicker();
            this.radClock1 = new Telerik.WinControls.UI.RadClock();
            this.pnlClok = new System.Windows.Forms.Panel();
            this.rtmOrarioPartenza = new Telerik.WinControls.UI.RadTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.rtmOrarioArrivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radClock1)).BeginInit();
            this.pnlClok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtmOrarioPartenza)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodiceVolo
            // 
            this.txtCodiceVolo.Location = new System.Drawing.Point(200, 64);
            this.txtCodiceVolo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodiceVolo.Name = "txtCodiceVolo";
            this.txtCodiceVolo.Size = new System.Drawing.Size(206, 27);
            this.txtCodiceVolo.TabIndex = 0;
            // 
            // lblCodiceVolo
            // 
            this.lblCodiceVolo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodiceVolo.Location = new System.Drawing.Point(57, 64);
            this.lblCodiceVolo.Name = "lblCodiceVolo";
            this.lblCodiceVolo.Size = new System.Drawing.Size(137, 31);
            this.lblCodiceVolo.TabIndex = 1;
            this.lblCodiceVolo.Text = "Codice Volo";
            this.lblCodiceVolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalva.Location = new System.Drawing.Point(95, 396);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(99, 51);
            this.btnSalva.TabIndex = 2;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnChiudi
            // 
            this.btnChiudi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChiudi.Location = new System.Drawing.Point(262, 396);
            this.btnChiudi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(99, 51);
            this.btnChiudi.TabIndex = 3;
            this.btnChiudi.Text = "Chiudi";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // cmbAeroportiPartenza
            // 
            this.cmbAeroportiPartenza.FormattingEnabled = true;
            this.cmbAeroportiPartenza.Location = new System.Drawing.Point(69, 319);
            this.cmbAeroportiPartenza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAeroportiPartenza.Name = "cmbAeroportiPartenza";
            this.cmbAeroportiPartenza.Size = new System.Drawing.Size(138, 28);
            this.cmbAeroportiPartenza.TabIndex = 8;
            // 
            // lblAeroportoPartenza
            // 
            this.lblAeroportoPartenza.Location = new System.Drawing.Point(69, 265);
            this.lblAeroportoPartenza.Name = "lblAeroportoPartenza";
            this.lblAeroportoPartenza.Size = new System.Drawing.Size(144, 35);
            this.lblAeroportoPartenza.TabIndex = 9;
            this.lblAeroportoPartenza.Text = "Aeroporto Partenza";
            this.lblAeroportoPartenza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(237, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Aeroporto Arrivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbAeroportiArrivo
            // 
            this.cmbAeroportiArrivo.FormattingEnabled = true;
            this.cmbAeroportiArrivo.Location = new System.Drawing.Point(243, 319);
            this.cmbAeroportiArrivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAeroportiArrivo.Name = "cmbAeroportiArrivo";
            this.cmbAeroportiArrivo.Size = new System.Drawing.Size(138, 28);
            this.cmbAeroportiArrivo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Orario di Partenza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Orario di arrivo";
            // 
            // rtmOrarioArrivo
            // 
            this.rtmOrarioArrivo.Location = new System.Drawing.Point(250, 193);
            this.rtmOrarioArrivo.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.rtmOrarioArrivo.MinValue = new System.DateTime(((long)(0)));
            this.rtmOrarioArrivo.Name = "rtmOrarioArrivo";
            this.rtmOrarioArrivo.Size = new System.Drawing.Size(156, 24);
            this.rtmOrarioArrivo.TabIndex = 21;
            this.rtmOrarioArrivo.TabStop = false;
            this.rtmOrarioArrivo.ThemeName = "Fluent";
            this.rtmOrarioArrivo.Value = new System.DateTime(2022, 3, 8, 11, 20, 30, 762);
            // 
            // radClock1
            // 
            this.radClock1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radClock1.Location = new System.Drawing.Point(12, 9);
            this.radClock1.Name = "radClock1";
            this.radClock1.Size = new System.Drawing.Size(134, 135);
            this.radClock1.TabIndex = 23;
            this.radClock1.ThemeName = "Fluent";
            // 
            // pnlClok
            // 
            this.pnlClok.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlClok.Controls.Add(this.radClock1);
            this.pnlClok.Location = new System.Drawing.Point(461, 145);
            this.pnlClok.Name = "pnlClok";
            this.pnlClok.Size = new System.Drawing.Size(160, 155);
            this.pnlClok.TabIndex = 24;
            // 
            // rtmOrarioPartenza
            // 
            this.rtmOrarioPartenza.Location = new System.Drawing.Point(57, 193);
            this.rtmOrarioPartenza.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.rtmOrarioPartenza.MinValue = new System.DateTime(((long)(0)));
            this.rtmOrarioPartenza.Name = "rtmOrarioPartenza";
            this.rtmOrarioPartenza.Size = new System.Drawing.Size(156, 28);
            this.rtmOrarioPartenza.TabIndex = 22;
            this.rtmOrarioPartenza.TabStop = false;
            this.rtmOrarioPartenza.ThemeName = "Fluent";
            this.rtmOrarioPartenza.Value = new System.DateTime(2022, 3, 8, 11, 20, 55, 548);
            // 
            // frmAddVolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 480);
            this.Controls.Add(this.pnlClok);
            this.Controls.Add(this.rtmOrarioPartenza);
            this.Controls.Add(this.rtmOrarioArrivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAeroportiArrivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAeroportoPartenza);
            this.Controls.Add(this.cmbAeroportiPartenza);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.lblCodiceVolo);
            this.Controls.Add(this.txtCodiceVolo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddVolo";
            this.Text = "frmAddVolo";
            this.Load += new System.EventHandler(this.frmAddVolo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rtmOrarioArrivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radClock1)).EndInit();
            this.pnlClok.ResumeLayout(false);
            this.pnlClok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtmOrarioPartenza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodiceVolo;
        private System.Windows.Forms.Label lblCodiceVolo;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnChiudi;
        private System.Windows.Forms.ComboBox cmbAeroportiPartenza;
        private System.Windows.Forms.Label lblAeroportoPartenza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAeroportiArrivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadTimePicker rtmOrarioArrivo;
        private Telerik.WinControls.UI.RadTimePicker rtmOrarioPartenza;
        private Telerik.WinControls.UI.RadClock radClock1;
        private System.Windows.Forms.Panel pnlClok;
    }
}