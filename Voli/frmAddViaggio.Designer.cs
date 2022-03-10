
namespace Voli
{
    partial class frmAddViaggio
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
            this.dtpSelectGiorno = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.clbSelectAssistenti = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSelectPilota = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSelectCopilota = new System.Windows.Forms.ComboBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpSelectGiorno
            // 
            this.dtpSelectGiorno.Location = new System.Drawing.Point(538, 96);
            this.dtpSelectGiorno.Name = "dtpSelectGiorno";
            this.dtpSelectGiorno.Size = new System.Drawing.Size(250, 27);
            this.dtpSelectGiorno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(550, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selezionare giorno del viaggio";
            // 
            // clbSelectAssistenti
            // 
            this.clbSelectAssistenti.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clbSelectAssistenti.FormattingEnabled = true;
            this.clbSelectAssistenti.Location = new System.Drawing.Point(12, 217);
            this.clbSelectAssistenti.Name = "clbSelectAssistenti";
            this.clbSelectAssistenti.Size = new System.Drawing.Size(317, 158);
            this.clbSelectAssistenti.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(84, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selezionare gli assistenti";
            // 
            // cmbSelectPilota
            // 
            this.cmbSelectPilota.FormattingEnabled = true;
            this.cmbSelectPilota.Location = new System.Drawing.Point(15, 98);
            this.cmbSelectPilota.Name = "cmbSelectPilota";
            this.cmbSelectPilota.Size = new System.Drawing.Size(151, 28);
            this.cmbSelectPilota.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selezionare pilota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(260, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Selezionare copilota";
            // 
            // cmbSelectCopilota
            // 
            this.cmbSelectCopilota.FormattingEnabled = true;
            this.cmbSelectCopilota.Location = new System.Drawing.Point(257, 98);
            this.cmbSelectCopilota.Name = "cmbSelectCopilota";
            this.cmbSelectCopilota.Size = new System.Drawing.Size(151, 28);
            this.cmbSelectCopilota.TabIndex = 6;
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalva.Location = new System.Drawing.Point(449, 321);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(107, 54);
            this.btnSalva.TabIndex = 8;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnChiudi
            // 
            this.btnChiudi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChiudi.Location = new System.Drawing.Point(587, 321);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(107, 54);
            this.btnChiudi.TabIndex = 9;
            this.btnChiudi.Text = "Chiudi";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // frmAddViaggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSelectCopilota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSelectPilota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clbSelectAssistenti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSelectGiorno);
            this.Name = "frmAddViaggio";
            this.Text = "frmAddViaggio";
            this.Load += new System.EventHandler(this.frmAddViaggio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSelectGiorno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbSelectAssistenti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSelectPilota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSelectCopilota;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnChiudi;
    }
}