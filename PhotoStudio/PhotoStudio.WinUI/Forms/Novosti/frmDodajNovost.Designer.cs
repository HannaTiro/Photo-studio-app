
namespace PhotoStudio.WinUI.Forms.Novosti
{
    partial class frmDodajNovost
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
            this.components = new System.ComponentModel.Container();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.lblAA = new System.Windows.Forms.Label();
            this.cmbStudio = new System.Windows.Forms.ComboBox();
            this.Studio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazivStudija = new System.Windows.Forms.TextBox();
            this.Datum = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(109, 312);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(143, 23);
            this.btnDodaj.TabIndex = 21;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(51, 105);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(201, 63);
            this.txtSadrzaj.TabIndex = 20;
            this.txtSadrzaj.Validating += new System.ComponentModel.CancelEventHandler(this.txtSadrzaj_Validating);
            // 
            // lblAA
            // 
            this.lblAA.AutoSize = true;
            this.lblAA.Location = new System.Drawing.Point(48, 79);
            this.lblAA.Name = "lblAA";
            this.lblAA.Size = new System.Drawing.Size(42, 13);
            this.lblAA.TabIndex = 19;
            this.lblAA.Text = "Sadržaj";
            // 
            // cmbStudio
            // 
            this.cmbStudio.FormattingEnabled = true;
            this.cmbStudio.Location = new System.Drawing.Point(51, 261);
            this.cmbStudio.Name = "cmbStudio";
            this.cmbStudio.Size = new System.Drawing.Size(201, 21);
            this.cmbStudio.TabIndex = 18;
            this.cmbStudio.Validating += new System.ComponentModel.CancelEventHandler(this.cmbStudio_Validating);
            // 
            // Studio
            // 
            this.Studio.AutoSize = true;
            this.Studio.Location = new System.Drawing.Point(48, 245);
            this.Studio.Name = "Studio";
            this.Studio.Size = new System.Drawing.Size(37, 13);
            this.Studio.TabIndex = 17;
            this.Studio.Text = "Studio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Naslov";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(51, 43);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(201, 20);
            this.txtNaslov.TabIndex = 13;
            this.txtNaslov.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaslov_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, -40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Naziv studija";
            // 
            // txtNazivStudija
            // 
            this.txtNazivStudija.Location = new System.Drawing.Point(190, -24);
            this.txtNazivStudija.Name = "txtNazivStudija";
            this.txtNazivStudija.Size = new System.Drawing.Size(201, 20);
            this.txtNazivStudija.TabIndex = 11;
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(50, 185);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(38, 13);
            this.Datum.TabIndex = 22;
            this.Datum.Text = "Datum";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Enabled = false;
            this.dtpDatum.Location = new System.Drawing.Point(51, 202);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 23;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmDodajNovost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(310, 386);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtSadrzaj);
            this.Controls.Add(this.lblAA);
            this.Controls.Add(this.cmbStudio);
            this.Controls.Add(this.Studio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazivStudija);
            this.Name = "frmDodajNovost";
            this.Text = "frmDodajNovost";
            this.Load += new System.EventHandler(this.frmDodajNovost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.Label lblAA;
        private System.Windows.Forms.ComboBox cmbStudio;
        private System.Windows.Forms.Label Studio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivStudija;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ErrorProvider err;
    }
}