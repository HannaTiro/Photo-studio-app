using PhotoStudio.Data.Requests.Fotograf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudio.WinUI.Forms.Fotografi
{
    public partial class frmDodajFotografa : Form
    {
        protected APIService _servisFotograf = new APIService("Fotograf");
        protected APIService _servisTipFotografa = new APIService("TipFotografa");

        public frmDodajFotografa()
        {
            InitializeComponent();
        }
        private async Task LoadTipFotografaAsync()
        {
            var lista = await _servisTipFotografa.Get<List<Data.Model.TipFotografa>>();
            lista.Insert(0, new Data.Model.TipFotografa());
            cmbTipFotografa.ValueMember = "TipFotografaId";
            cmbTipFotografa.DisplayMember = "Naziv";
            cmbTipFotografa.DataSource = lista;
        }
        private async void frmDodajFotografa_Load(object sender, EventArgs e)
        {
            LoadTipFotografaAsync();
        }

     

        private void cmbTipFotografa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                err.SetError(txtIme, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                err.SetError(txtPrezime, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                err.SetError(txtEmail, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtEmail, null);
            }
        }

        private void txtKontakt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKontakt.Text))
            {
                err.SetError(txtKontakt, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtKontakt, null);
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCijena.Text))
            {
                err.SetError(txtCijena, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtCijena, null);
            }
        }

        private void cmbTipFotografa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbTipFotografa.Text))
            {
                err.SetError(cmbTipFotografa, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                err.SetError(cmbTipFotografa, null);
            }
        }

        private void txtSlika_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSlika.Text))
            {
                err.SetError(txtSlika, " Required");
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtSlika, null);
            }
        }
        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOpis.Text))
            {
                err.SetError(txtOpis, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtOpis, null);
            }
        }

        FotografUpsert request = new FotografUpsert();
        private async void btnDodaj_ClickAsync(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                request.Ime = txtIme.Text;
                request.Prezime = txtPrezime.Text;
                request.Status = cbDostupan.Checked;
                request.Opis = txtOpis.Text;
                request.DnevnaCijena = double.Parse(txtCijena.Text);
                var tipId = cmbTipFotografa.SelectedValue;
                if(int.TryParse(tipId.ToString(),out int TipId))
                {
                    request.TipFotografaId = TipId;
                }



                await _servisFotograf.Insert<Data.Model.Fotograf>(request);
                MessageBox.Show("Fotograf je dodan u bazu", "Poruka", MessageBoxButtons.OK);
                this.Close();
            }
            MessageBox.Show("Morate unijeti ispravne podatke da biste dodali fotografa", "Poruka", MessageBoxButtons.OK);

        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Slika = file;
                txtSlika.Text = fileName;

                Image img = Image.FromFile(fileName);
                pbSlika.Image = img;
                pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}

