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
    public partial class frmOpremaDetalji : Form
    {
        APIService _serviceOprema = new APIService("Oprema");
        private int? _id = null;

        public frmOpremaDetalji(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmOpremaDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var podaci = await _serviceOprema.GetById<Data.Model.Oprema>(_id);
                txtNaziv.Text = podaci.Naziv;
                txtOpis.Text = podaci.Opis;
                txtKolicina.Text = podaci.Kolicina.ToString();
              

            }
        }
        OpremaUpsert request = new OpremaUpsert();
     
        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {

                var podaci = await _serviceOprema.GetById<Data.Model.Oprema>(_id);
                request.StudioId = podaci.StudioId; 
                if (this.ValidateChildren())
                {
                    request.Naziv = txtNaziv.Text;
                    request.Kolicina = int.Parse(txtKolicina.Text);
                   
                    request.Opis = txtOpis.Text;

                    await _serviceOprema.Update<Data.Model.Oprema>(_id, request);
                    MessageBox.Show("Podaci o opremi su izmijenjeni", "Poruka", MessageBoxButtons.OK);
                    this.Close();
                }
               
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
    }
}
