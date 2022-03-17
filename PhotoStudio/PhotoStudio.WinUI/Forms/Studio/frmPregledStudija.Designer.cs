
namespace PhotoStudio.WinUI.Forms.Studio
{
    partial class frmPregledStudija
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
            this.dgvStudio = new System.Windows.Forms.DataGridView();
            this.StudioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista otvorenih poslovnica";
            // 
            // dgvStudio
            // 
            this.dgvStudio.AllowUserToAddRows = false;
            this.dgvStudio.AllowUserToDeleteRows = false;
            this.dgvStudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudioId,
            this.Adresa,
            this.Telefon,
            this.Opis});
            this.dgvStudio.Location = new System.Drawing.Point(15, 42);
            this.dgvStudio.Name = "dgvStudio";
            this.dgvStudio.ReadOnly = true;
            this.dgvStudio.Size = new System.Drawing.Size(536, 208);
            this.dgvStudio.TabIndex = 1;
            // 
            // StudioId
            // 
            this.StudioId.DataPropertyName = "StudioId";
            this.StudioId.HeaderText = "StudioId";
            this.StudioId.Name = "StudioId";
            this.StudioId.ReadOnly = true;
            this.StudioId.Visible = false;
            // 
            // Adresa
            // 
            this.Adresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // frmPregledStudija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(574, 274);
            this.Controls.Add(this.dgvStudio);
            this.Controls.Add(this.label1);
            this.Name = "frmPregledStudija";
            this.Text = "frmPregledStudija";
            this.Load += new System.EventHandler(this.frmPregledStudija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStudio;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
    }
}