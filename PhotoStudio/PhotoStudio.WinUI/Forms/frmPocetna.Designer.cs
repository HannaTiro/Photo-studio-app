﻿
namespace PhotoStudio.WinUI.Forms
{
    partial class frmPocetna
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajKorisnikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fotografiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajFotografeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajFotografaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajRezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocjeneIKomentariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajOcjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajKomentareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledStudijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajStudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledNovostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posebnePonudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPonudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajSveUslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovuUsluguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.uvidUOpremuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajSvuOpremuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovuStavkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.fotografiToolStripMenuItem,
            this.rezervacijeToolStripMenuItem,
            this.ocjeneIKomentariToolStripMenuItem,
            this.oNamaToolStripMenuItem,
            this.pregledStudijaToolStripMenuItem,
            this.novostiToolStripMenuItem,
            this.posebnePonudeToolStripMenuItem,
            this.uslugeToolStripMenuItem,
            this.uvidUOpremuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(907, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledajKorisnikeToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pregledajKorisnikeToolStripMenuItem
            // 
            this.pregledajKorisnikeToolStripMenuItem.Name = "pregledajKorisnikeToolStripMenuItem";
            this.pregledajKorisnikeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pregledajKorisnikeToolStripMenuItem.Text = "Pregledaj korisnike";
            this.pregledajKorisnikeToolStripMenuItem.Click += new System.EventHandler(this.pregledajKorisnikeToolStripMenuItem_Click);
            // 
            // fotografiToolStripMenuItem
            // 
            this.fotografiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledajFotografeToolStripMenuItem,
            this.dodajFotografaToolStripMenuItem});
            this.fotografiToolStripMenuItem.Name = "fotografiToolStripMenuItem";
            this.fotografiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fotografiToolStripMenuItem.Text = "Fotografi";
            // 
            // pregledajFotografeToolStripMenuItem
            // 
            this.pregledajFotografeToolStripMenuItem.Name = "pregledajFotografeToolStripMenuItem";
            this.pregledajFotografeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.pregledajFotografeToolStripMenuItem.Text = "Pregledaj fotografe";
            this.pregledajFotografeToolStripMenuItem.Click += new System.EventHandler(this.pregledajFotografeToolStripMenuItem_Click);
            // 
            // dodajFotografaToolStripMenuItem
            // 
            this.dodajFotografaToolStripMenuItem.Name = "dodajFotografaToolStripMenuItem";
            this.dodajFotografaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.dodajFotografaToolStripMenuItem.Text = "Dodaj fotografa";
            this.dodajFotografaToolStripMenuItem.Click += new System.EventHandler(this.dodajFotografaToolStripMenuItem_Click);
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledajRezervacijeToolStripMenuItem});
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.rezervacijeToolStripMenuItem.Text = "Rezervacije";
            // 
            // pregledajRezervacijeToolStripMenuItem
            // 
            this.pregledajRezervacijeToolStripMenuItem.Name = "pregledajRezervacijeToolStripMenuItem";
            this.pregledajRezervacijeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.pregledajRezervacijeToolStripMenuItem.Text = "Pregledaj rezervacije";
            this.pregledajRezervacijeToolStripMenuItem.Click += new System.EventHandler(this.pregledajRezervacijeToolStripMenuItem_Click);
            // 
            // ocjeneIKomentariToolStripMenuItem
            // 
            this.ocjeneIKomentariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledajOcjeneToolStripMenuItem,
            this.pregledajKomentareToolStripMenuItem});
            this.ocjeneIKomentariToolStripMenuItem.Name = "ocjeneIKomentariToolStripMenuItem";
            this.ocjeneIKomentariToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.ocjeneIKomentariToolStripMenuItem.Text = "Ocjene i komentari";
            // 
            // pregledajOcjeneToolStripMenuItem
            // 
            this.pregledajOcjeneToolStripMenuItem.Name = "pregledajOcjeneToolStripMenuItem";
            this.pregledajOcjeneToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.pregledajOcjeneToolStripMenuItem.Text = "Pregledaj ocjene";
            this.pregledajOcjeneToolStripMenuItem.Click += new System.EventHandler(this.pregledajOcjeneToolStripMenuItem_Click);
            // 
            // pregledajKomentareToolStripMenuItem
            // 
            this.pregledajKomentareToolStripMenuItem.Name = "pregledajKomentareToolStripMenuItem";
            this.pregledajKomentareToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.pregledajKomentareToolStripMenuItem.Text = "Pregledaj komentare";
            this.pregledajKomentareToolStripMenuItem.Click += new System.EventHandler(this.pregledajKomentareToolStripMenuItem_Click);
            // 
            // oNamaToolStripMenuItem
            // 
            this.oNamaToolStripMenuItem.Name = "oNamaToolStripMenuItem";
            this.oNamaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.oNamaToolStripMenuItem.Text = "O nama";
            this.oNamaToolStripMenuItem.Click += new System.EventHandler(this.oNamaToolStripMenuItem_Click);
            // 
            // pregledStudijaToolStripMenuItem
            // 
            this.pregledStudijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajStudioToolStripMenuItem});
            this.pregledStudijaToolStripMenuItem.Name = "pregledStudijaToolStripMenuItem";
            this.pregledStudijaToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.pregledStudijaToolStripMenuItem.Text = "Pregled studija";
            this.pregledStudijaToolStripMenuItem.Click += new System.EventHandler(this.pregledStudijaToolStripMenuItem_Click);
            // 
            // dodajStudioToolStripMenuItem
            // 
            this.dodajStudioToolStripMenuItem.Name = "dodajStudioToolStripMenuItem";
            this.dodajStudioToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.dodajStudioToolStripMenuItem.Text = "Dodaj studio";
            this.dodajStudioToolStripMenuItem.Click += new System.EventHandler(this.dodajStudioToolStripMenuItem_Click);
            // 
            // novostiToolStripMenuItem
            // 
            this.novostiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledNovostiToolStripMenuItem,
            this.dodajNovostToolStripMenuItem});
            this.novostiToolStripMenuItem.Name = "novostiToolStripMenuItem";
            this.novostiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.novostiToolStripMenuItem.Text = "Novosti";
            // 
            // pregledNovostiToolStripMenuItem
            // 
            this.pregledNovostiToolStripMenuItem.Name = "pregledNovostiToolStripMenuItem";
            this.pregledNovostiToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pregledNovostiToolStripMenuItem.Text = "Pregled novosti";
            this.pregledNovostiToolStripMenuItem.Click += new System.EventHandler(this.pregledNovostiToolStripMenuItem_Click);
            // 
            // dodajNovostToolStripMenuItem
            // 
            this.dodajNovostToolStripMenuItem.Name = "dodajNovostToolStripMenuItem";
            this.dodajNovostToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dodajNovostToolStripMenuItem.Text = "Dodaj novost";
            this.dodajNovostToolStripMenuItem.Click += new System.EventHandler(this.dodajNovostToolStripMenuItem_Click);
            // 
            // posebnePonudeToolStripMenuItem
            // 
            this.posebnePonudeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledPonudaToolStripMenuItem,
            this.dodajNovuToolStripMenuItem});
            this.posebnePonudeToolStripMenuItem.Name = "posebnePonudeToolStripMenuItem";
            this.posebnePonudeToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.posebnePonudeToolStripMenuItem.Text = "Posebne ponude";
            // 
            // pregledPonudaToolStripMenuItem
            // 
            this.pregledPonudaToolStripMenuItem.Name = "pregledPonudaToolStripMenuItem";
            this.pregledPonudaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pregledPonudaToolStripMenuItem.Text = "Pregled ponuda";
            this.pregledPonudaToolStripMenuItem.Click += new System.EventHandler(this.pregledPonudaToolStripMenuItem_Click);
            // 
            // dodajNovuToolStripMenuItem
            // 
            this.dodajNovuToolStripMenuItem.Name = "dodajNovuToolStripMenuItem";
            this.dodajNovuToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.dodajNovuToolStripMenuItem.Text = "Dodaj novu";
            this.dodajNovuToolStripMenuItem.Click += new System.EventHandler(this.dodajNovuToolStripMenuItem_Click);
            // 
            // uslugeToolStripMenuItem
            // 
            this.uslugeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledajSveUslugeToolStripMenuItem,
            this.dodajNovuUsluguToolStripMenuItem});
            this.uslugeToolStripMenuItem.Name = "uslugeToolStripMenuItem";
            this.uslugeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.uslugeToolStripMenuItem.Text = "Usluge";
            // 
            // pregledajSveUslugeToolStripMenuItem
            // 
            this.pregledajSveUslugeToolStripMenuItem.Name = "pregledajSveUslugeToolStripMenuItem";
            this.pregledajSveUslugeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.pregledajSveUslugeToolStripMenuItem.Text = "Pregledaj sve usluge";
            this.pregledajSveUslugeToolStripMenuItem.Click += new System.EventHandler(this.pregledajSveUslugeToolStripMenuItem_Click);
            // 
            // dodajNovuUsluguToolStripMenuItem
            // 
            this.dodajNovuUsluguToolStripMenuItem.Name = "dodajNovuUsluguToolStripMenuItem";
            this.dodajNovuUsluguToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.dodajNovuUsluguToolStripMenuItem.Text = "Dodaj novu uslugu";
            this.dodajNovuUsluguToolStripMenuItem.Click += new System.EventHandler(this.dodajNovuUsluguToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 435);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(907, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // uvidUOpremuToolStripMenuItem
            // 
            this.uvidUOpremuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledajSvuOpremuToolStripMenuItem,
            this.dodajNovuStavkuToolStripMenuItem});
            this.uvidUOpremuToolStripMenuItem.Name = "uvidUOpremuToolStripMenuItem";
            this.uvidUOpremuToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.uvidUOpremuToolStripMenuItem.Text = "Uvid u opremu";
            // 
            // pregledajSvuOpremuToolStripMenuItem
            // 
            this.pregledajSvuOpremuToolStripMenuItem.Name = "pregledajSvuOpremuToolStripMenuItem";
            this.pregledajSvuOpremuToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.pregledajSvuOpremuToolStripMenuItem.Text = "Pregledaj svu opremu";
            this.pregledajSvuOpremuToolStripMenuItem.Click += new System.EventHandler(this.pregledajSvuOpremuToolStripMenuItem_Click);
            // 
            // dodajNovuStavkuToolStripMenuItem
            // 
            this.dodajNovuStavkuToolStripMenuItem.Name = "dodajNovuStavkuToolStripMenuItem";
            this.dodajNovuStavkuToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.dodajNovuStavkuToolStripMenuItem.Text = "Dodaj novu stavku";
            this.dodajNovuStavkuToolStripMenuItem.Click += new System.EventHandler(this.dodajNovuStavkuToolStripMenuItem_Click);
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(907, 457);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPocetna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPocetna_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajKorisnikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fotografiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajFotografeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajRezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocjeneIKomentariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajOcjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajKomentareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajFotografaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledStudijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajStudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novostiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledNovostiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posebnePonudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPonudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajSveUslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovuUsluguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uvidUOpremuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajSvuOpremuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovuStavkuToolStripMenuItem;
    }
}



