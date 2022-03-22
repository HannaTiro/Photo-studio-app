using PhotoStudio.Data.Requests.Usluga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudio.WinUI.Forms.Usluga
{
    public partial class frmDodajUslugu : Form
    {
        protected APIService _serviceUsluga = new APIService("Usluga");
        protected APIService _serviceStudio = new APIService("Studio");
        public frmDodajUslugu()
        {
            InitializeComponent();
        }

        private async void frmDodajUslugu_Load(object sender, EventArgs e)
        {
            var list = await _serviceStudio.Get<List<Data.Model.Studio>>();
            list.Insert(0, new Data.Model.Studio());

            cmbStudio.DisplayMember = "NazivStudija";
            cmbStudio.ValueMember = "StudioId";

            cmbStudio.DataSource = list;
        }
        UslugaUpsert request = new UslugaUpsert();

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                request.Naziv = txtNaziv.Text;
                request.Cijena = double.Parse(txtCijena.Text);
                var odabraniStudio = cmbStudio.SelectedValue;
                if (int.TryParse(odabraniStudio.ToString(), out int studio))
                {
                    request.StudioId = studio;
                }
              
              
                    await _serviceUsluga.Insert<Data.Model.Usluga>(request);
                    MessageBox.Show("Uspješno ste dodali novu ponudu", "Poruka", MessageBoxButtons.OK);
                    this.Close();
                



            }
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

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCijena.Text))
            {
                err.SetError(txtCijena, " Obavezno polje");
                e.Cancel = true;
            }
          else  if (System.Text.RegularExpressions.Regex.IsMatch(txtCijena.Text, "[^0-9]"))
            {
                    MessageBox.Show("Molimo Vas unesite samo brojeve.");
                e.Cancel = true;

            }

            else
            {
                err.SetError(txtCijena, null);
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
    }
}
