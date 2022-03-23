using PhotoStudio.WinUI.Forms.Fotografi;
using PhotoStudio.WinUI.Forms.Komentari;
using PhotoStudio.WinUI.Forms.Korisnici;
using PhotoStudio.WinUI.Forms.Novosti;
using PhotoStudio.WinUI.Forms.Ocjene;
using PhotoStudio.WinUI.Forms.Oprema;
using PhotoStudio.WinUI.Forms.PosebnaPonuda;
using PhotoStudio.WinUI.Forms.Rezervacije;
using PhotoStudio.WinUI.Forms.Studio;
using PhotoStudio.WinUI.Forms.Usluga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudio.WinUI.Forms
{
    public partial class frmPocetna : Form
    {
        private int childFormNumber = 0;

        public frmPocetna()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

     

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            frmHome forma = new frmHome();
            forma.MdiParent = this;
            forma.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome forma = new frmHome();
            forma.MdiParent = this;
            forma.Show();
        }

        private void pregledajKorisnikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnici forma = new frmKorisnici();
            forma.MdiParent = this;
            forma.Show();
        }

        private void pregledajFotografeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFotografi forma = new frmFotografi();
            forma.MdiParent = this;
            forma.Show();
        }

        private void dodajFotografaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajFotografa forma = new frmDodajFotografa();
            forma.MdiParent = this;
            forma.Show();
        }

        private void pregledajRezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRezervacije forma = new frmRezervacije();
            forma.MdiParent = this;
            forma.Show();
        }

        private void pregledajOcjeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOcjene forma = new frmOcjene();
            forma.MdiParent = this;
            forma.Show();
        }

        private void pregledajKomentareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKomentari forma = new frmKomentari();
            forma.MdiParent = this;
            forma.Show();
        }

        private void oNamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmONama forma = new frmONama();
            forma.MdiParent = this;
            forma.Show();
        }

      

        private void pregledStudijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledStudija forma = new frmPregledStudija();
            forma.MdiParent = this;
            forma.Show();
        }

        private void dodajStudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNoviStudio forma = new frmNoviStudio();
            forma.MdiParent = this;
            forma.Show();
        }

        private void pregledNovostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledNovosti forma = new frmPregledNovosti();
            forma.MdiParent = this;
            forma.Show();
        }

        private void dodajNovostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajNovost forma = new frmDodajNovost();
            forma.MdiParent = this;
            forma.Show();
        }

        private void pregledPonudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledPonuda forma = new frmPregledPonuda();
            forma.MdiParent = this;
            forma.Show();
        }

        private void dodajNovuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPosebnaPonudaDodaj forma = new frmPosebnaPonudaDodaj();
            forma.MdiParent = this;
            forma.Show();
        }

        private void pregledajSveUslugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledUsluga forma = new frmPregledUsluga();
            forma.MdiParent = this;
            forma.Show();
        }

        private void dodajNovuUsluguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajUslugu forma = new frmDodajUslugu();
            forma.MdiParent = this;
            forma.Show();
        }

        private void pregledajSvuOpremuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledOpreme forma = new frmPregledOpreme();
            forma.MdiParent = this;
            forma.Show();
        }

        private void dodajNovuStavkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpremaDodaj forma = new frmOpremaDodaj();
            forma.MdiParent = this;
            forma.Show();
        }
    }
}
