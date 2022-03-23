using PhotoStudio.Data.Requests.Oprema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudio.WinUI.Forms.Oprema
{
    public partial class frmOpremaDodaj : Form
    {
        APIService _serviceOprema = new APIService("Oprema");
        APIService _serviceStudio = new APIService("Studio");


        public frmOpremaDodaj()
        {
            InitializeComponent();
        }

        private async void frmOpremaDodaj_Load(object sender, EventArgs e)
        {
            var list = await _serviceStudio.Get<List<Data.Model.Studio>>();
            list.Insert(0, new Data.Model.Studio());

            cmbStudio.DisplayMember = "NazivStudija";
            cmbStudio.ValueMember = "StudioId";

            cmbStudio.DataSource = list;
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                err.SetError(txtNaziv, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtNaziv, null);
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

        private void txtKolicina_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKolicina.Text))
            {
                err.SetError(txtKolicina, " Obavezno polje");
                e.Cancel = true;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(txtKolicina.Text, "[^0-9]"))
            {
                MessageBox.Show("Molimo Vas unesite samo brojeve.");
                e.Cancel = true;

            }
            else
            {
                err.SetError(txtOpis, null);
            }
        }

        private void cmbStudio_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbStudio.Text))
            {
                err.SetError(cmbStudio, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                err.SetError(cmbStudio, null);
            }
        }
        OpremaUpsert request = new OpremaUpsert();

        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                request.Naziv = txtNaziv.Text;
                request.Kolicina = int.Parse(txtKolicina.Text);
                request.Opis = txtOpis.Text;
                var odabraniStudio = cmbStudio.SelectedValue;
                if (int.TryParse(odabraniStudio.ToString(), out int studio))
                {
                    request.StudioId = studio;
                }
              
                var search = new OpremaSearchRequest
                {
                    Naziv = txtNaziv.Text,
                   StudioId=request.StudioId
                };
                var listaOpreme = await _serviceOprema.Get<List<Data.Model.Oprema>>(search);
                if (listaOpreme.Count >= 1)
                {
                    MessageBox.Show("Takva oprema u ovom studiju već postoji, povećajte samo količinu", "Greška", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    await _serviceOprema.Insert<Data.Model.Oprema>(request);
                    MessageBox.Show("Uspješno ste dodali novu ponudu", "Poruka", MessageBoxButtons.OK);
                    this.Close();
                }


             




            }
        }
    }
}
