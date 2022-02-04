
namespace PhotoStudio.WinUI.Forms.Ocjene
{
    partial class frmOcjene
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvRejting = new System.Windows.Forms.DataGridView();
            this.RejtingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeFotografa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrezimeFotografa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRejting)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime fotografa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime fotografa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ocjena";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(49, 39);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(183, 20);
            this.txtIme.TabIndex = 3;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(49, 110);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(183, 20);
            this.txtPrezime.TabIndex = 4;
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(285, 39);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(183, 20);
            this.txtOcjena.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(333, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvRejting
            // 
            this.dgvRejting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRejting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RejtingId,
            this.ImeFotografa,
            this.PrezimeFotografa,
            this.Ocjena});
            this.dgvRejting.Location = new System.Drawing.Point(49, 172);
            this.dgvRejting.Name = "dgvRejting";
            this.dgvRejting.ReadOnly = true;
            this.dgvRejting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRejting.Size = new System.Drawing.Size(419, 150);
            this.dgvRejting.TabIndex = 7;
            this.dgvRejting.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRejting_CellContentClick);
            // 
            // RejtingId
            // 
            this.RejtingId.DataPropertyName = "RejtingId";
            this.RejtingId.HeaderText = "RejtingId";
            this.RejtingId.Name = "RejtingId";
            this.RejtingId.ReadOnly = true;
            this.RejtingId.Visible = false;
            // 
            // ImeFotografa
            // 
            this.ImeFotografa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImeFotografa.DataPropertyName = "ImeFotografa";
            this.ImeFotografa.HeaderText = "Ime fotografa";
            this.ImeFotografa.Name = "ImeFotografa";
            this.ImeFotografa.ReadOnly = true;
            // 
            // PrezimeFotografa
            // 
            this.PrezimeFotografa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrezimeFotografa.DataPropertyName = "PrezimeFotografa";
            this.PrezimeFotografa.HeaderText = "Prezime fotografa";
            this.PrezimeFotografa.Name = "PrezimeFotografa";
            this.PrezimeFotografa.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // frmOcjene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::PhotoStudio.WinUI.Properties.Resources.logo;
            this.ClientSize = new System.Drawing.Size(539, 361);
            this.Controls.Add(this.dgvRejting);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOcjene";
            this.Text = "frmOcjene";
            this.Load += new System.EventHandler(this.frmOcjene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRejting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvRejting;
        private System.Windows.Forms.DataGridViewTextBoxColumn RejtingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeFotografa;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrezimeFotografa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
    }
}