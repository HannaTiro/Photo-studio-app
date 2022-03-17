using PhotoStudio.Data.Model;
using PhotoStudio.Data.Requests.Studio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudio.WinUI.Forms.Studio
{
    public partial class frmNoviStudio : Form
    {
        protected APIService _serviceStudio = new APIService("Studio");
        protected APIService _serviceGrad = new APIService("Grad");

        public frmNoviStudio()
        {
            InitializeComponent();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                var studio = new StudioUpsert
                {
                    Adresa = txtAdresa.Text,
                    NazivStudija = txtNazivStudija.Text,
                    Opis = txtOpis.Text,
                    Telefon = txtTelefon.Text
                };
                var odabraniGrad = cmbGrad.SelectedValue;
                if(int.TryParse(odabraniGrad.ToString(), out int grad ))
                {
                    studio.GradId = grad;
                }
                var search = new StudioSearchRequest
                {
                    Telefon = txtTelefon.Text,
                    Adresa = txtAdresa.Text
                };
                var listaStudija = await _serviceStudio.Get<List<Data.Model.Studio>>(search);
                if(listaStudija.Count>=1)
                {
                    MessageBox.Show("Greška", "Studio sa ovom adresom i telefonskim brojem već postoji", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    await _serviceStudio.Insert<Data.Model.Studio>(studio);
                    MessageBox.Show("Poruka", "Uspješno ste dodali novu poslovnicu", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }
        private async Task UcitajGradove()
        {
            var list = await _serviceGrad.Get<List<Grad>>();
            list.Insert(0, new Grad());

            cmbGrad.DisplayMember = "NazivGrada";
            cmbGrad.ValueMember = "GradId";

            cmbGrad.DataSource = list;
        }

        private async  void frmNoviStudio_Load(object sender, EventArgs e)
        {
            await UcitajGradove();
        }

        private void txtNazivStudija_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNazivStudija.Text))
            {
                err.SetError(txtNazivStudija, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtNazivStudija, null);
            }
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                err.SetError(txtAdresa, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtAdresa, null);
            }
        }

        private void txtTelefon_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                err.SetError(txtTelefon, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtTelefon, null);
            }
        }

        private void cmbGrad_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbGrad.Text))
            {
                err.SetError(cmbGrad, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                err.SetError(cmbGrad, null);
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
    }
}
