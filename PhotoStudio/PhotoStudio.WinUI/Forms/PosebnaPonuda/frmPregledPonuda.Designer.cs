﻿
namespace PhotoStudio.WinUI.Forms.PosebnaPonuda
{
    partial class frmPregledPonuda
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
            this.dgvPonude = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivPonude = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PosebnaPonudaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivPonude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonude)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPonude
            // 
            this.dgvPonude.AllowUserToDeleteRows = false;
            this.dgvPonude.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonude.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PosebnaPonudaId,
            this.NazivPonude,
            this.Opis});
            this.dgvPonude.Location = new System.Drawing.Point(12, 165);
            this.dgvPonude.Name = "dgvPonude";
            this.dgvPonude.ReadOnly = true;
            this.dgvPonude.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPonude.Size = new System.Drawing.Size(475, 150);
            this.dgvPonude.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNazivPonude);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 127);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(151, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(272, 42);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(160, 20);
            this.txtOpis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis";
            // 
            // txtNazivPonude
            // 
            this.txtNazivPonude.Location = new System.Drawing.Point(43, 42);
            this.txtNazivPonude.Name = "txtNazivPonude";
            this.txtNazivPonude.Size = new System.Drawing.Size(160, 20);
            this.txtNazivPonude.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv ponude";
            // 
            // PosebnaPonudaId
            // 
            this.PosebnaPonudaId.DataPropertyName = "PosebnaPonudaId";
            this.PosebnaPonudaId.HeaderText = "PosebnaPonudaId";
            this.PosebnaPonudaId.Name = "PosebnaPonudaId";
            this.PosebnaPonudaId.ReadOnly = true;
            this.PosebnaPonudaId.Visible = false;
            // 
            // NazivPonude
            // 
            this.NazivPonude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivPonude.DataPropertyName = "NazivPonude";
            this.NazivPonude.HeaderText = "Naziv ponude";
            this.NazivPonude.Name = "NazivPonude";
            this.NazivPonude.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // frmPregledPonuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::PhotoStudio.WinUI.Properties.Resources.logo;
            this.ClientSize = new System.Drawing.Size(517, 344);
            this.Controls.Add(this.dgvPonude);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPregledPonuda";
            this.Text = "frmPregledPonuda";
            this.Load += new System.EventHandler(this.frmPregledPonuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonude)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPonude;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivPonude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosebnaPonudaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivPonude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
    }
}