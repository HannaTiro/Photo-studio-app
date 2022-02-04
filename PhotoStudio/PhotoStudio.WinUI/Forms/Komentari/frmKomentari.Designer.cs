
namespace PhotoStudio.WinUI.Forms.Komentari
{
    partial class frmKomentari
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImeKorisnika = new System.Windows.Forms.TextBox();
            this.txtPrezimeKorisnika = new System.Windows.Forms.TextBox();
            this.txtFotografId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvKomentari = new System.Windows.Forms.DataGridView();
            this.KomentarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeKorisnika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrezimeKorisnika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentari)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime korisnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime korisnika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fotograf ID";
            // 
            // txtImeKorisnika
            // 
            this.txtImeKorisnika.Location = new System.Drawing.Point(47, 41);
            this.txtImeKorisnika.Name = "txtImeKorisnika";
            this.txtImeKorisnika.Size = new System.Drawing.Size(171, 20);
            this.txtImeKorisnika.TabIndex = 3;
            // 
            // txtPrezimeKorisnika
            // 
            this.txtPrezimeKorisnika.Location = new System.Drawing.Point(47, 115);
            this.txtPrezimeKorisnika.Name = "txtPrezimeKorisnika";
            this.txtPrezimeKorisnika.Size = new System.Drawing.Size(171, 20);
            this.txtPrezimeKorisnika.TabIndex = 4;
            // 
            // txtFotografId
            // 
            this.txtFotografId.Location = new System.Drawing.Point(318, 41);
            this.txtFotografId.Name = "txtFotografId";
            this.txtFotografId.Size = new System.Drawing.Size(171, 20);
            this.txtFotografId.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(342, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvKomentari
            // 
            this.dgvKomentari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomentari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KomentarId,
            this.ImeKorisnika,
            this.PrezimeKorisnika,
            this.Opis});
            this.dgvKomentari.Location = new System.Drawing.Point(47, 162);
            this.dgvKomentari.Name = "dgvKomentari";
            this.dgvKomentari.ReadOnly = true;
            this.dgvKomentari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKomentari.Size = new System.Drawing.Size(442, 150);
            this.dgvKomentari.TabIndex = 7;
            this.dgvKomentari.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKomentari_CellContentClick);
            // 
            // KomentarId
            // 
            this.KomentarId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KomentarId.DataPropertyName = "KomentarId";
            this.KomentarId.HeaderText = "KomentarId";
            this.KomentarId.Name = "KomentarId";
            this.KomentarId.ReadOnly = true;
            this.KomentarId.Visible = false;
            // 
            // ImeKorisnika
            // 
            this.ImeKorisnika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImeKorisnika.DataPropertyName = "ImeKorisnika";
            this.ImeKorisnika.HeaderText = "ImeKorisnika";
            this.ImeKorisnika.Name = "ImeKorisnika";
            this.ImeKorisnika.ReadOnly = true;
            // 
            // PrezimeKorisnika
            // 
            this.PrezimeKorisnika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrezimeKorisnika.DataPropertyName = "PrezimeKorisnika";
            this.PrezimeKorisnika.HeaderText = "PrezimeKorisnika";
            this.PrezimeKorisnika.Name = "PrezimeKorisnika";
            this.PrezimeKorisnika.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // frmKomentari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::PhotoStudio.WinUI.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(525, 359);
            this.Controls.Add(this.dgvKomentari);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFotografId);
            this.Controls.Add(this.txtPrezimeKorisnika);
            this.Controls.Add(this.txtImeKorisnika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKomentari";
            this.Text = "frmKomentari";
            this.Load += new System.EventHandler(this.frmKomentari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImeKorisnika;
        private System.Windows.Forms.TextBox txtPrezimeKorisnika;
        private System.Windows.Forms.TextBox txtFotografId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvKomentari;
        private System.Windows.Forms.DataGridViewTextBoxColumn KomentarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeKorisnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrezimeKorisnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
    }
}