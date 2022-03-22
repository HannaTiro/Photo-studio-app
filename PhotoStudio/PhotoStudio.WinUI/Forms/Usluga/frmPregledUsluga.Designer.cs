
namespace PhotoStudio.WinUI.Forms.Usluga
{
    partial class frmPregledUsluga
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
            this.dgvUsluge = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UslugaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsluge
            // 
            this.dgvUsluge.AllowUserToDeleteRows = false;
            this.dgvUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsluge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UslugaId,
            this.Naziv,
            this.Cijena});
            this.dgvUsluge.Location = new System.Drawing.Point(22, 143);
            this.dgvUsluge.Name = "dgvUsluge";
            this.dgvUsluge.ReadOnly = true;
            this.dgvUsluge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsluge.Size = new System.Drawing.Size(475, 150);
            this.dgvUsluge.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 87);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(265, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(43, 42);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(160, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv usluge";
            // 
            // UslugaId
            // 
            this.UslugaId.DataPropertyName = "UslugaId";
            this.UslugaId.HeaderText = "UslugaId";
            this.UslugaId.Name = "UslugaId";
            this.UslugaId.ReadOnly = true;
            this.UslugaId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena (KM)";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // frmPregledUsluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhotoStudio.WinUI.Properties.Resources.logo;
            this.ClientSize = new System.Drawing.Size(528, 358);
            this.Controls.Add(this.dgvUsluge);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPregledUsluga";
            this.Text = "frmPregledUsluga";
            this.Load += new System.EventHandler(this.frmPregledUsluga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsluge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UslugaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}