using PhotoStudio.Data.Requests.Novost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PhotoStudio.WinUI.Forms.Novosti
{
    public partial class frmDodajNovost : Form
    {
        protected APIService _serviceNovost = new APIService("Novost");
        protected APIService _serviceStudio= new APIService("Studio");
        public frmDodajNovost()
        {
            InitializeComponent();
        }
        NovostUpsert request = new NovostUpsert();
        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
              
                request.Naslov = txtNaslov.Text;
                request.Sadrzaj = txtSadrzaj.Text;
                request.DatumObjave = DateTime.Now;
                var odabraniStudio = cmbStudio.SelectedValue;
                if (int.TryParse(odabraniStudio.ToString(), out int studio))
                {
                    request.StudioId = studio;
                }
               
     
                var search = new NovostSearchRequest
                {
                    Naslov = txtNaslov.Text,
                    StudioId = request.StudioId,
                    Sadrzaj=txtSadrzaj.Text
                };
                var listaNovosti = await _serviceNovost.Get<List<Data.Model.Novost>>(search);
                if (listaNovosti.Count >= 1)
                {
                    MessageBox.Show("Tu novost ste već objavili u ovom studiju", "Greška", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    await _serviceNovost.Insert<Data.Model.Novost>(request);
                    MessageBox.Show("Poruka", "Uspješno ste dodali novu novost", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private async void frmDodajNovost_Load(object sender, EventArgs e)
        {
            var list = await _serviceStudio.Get<List<Data.Model.Studio>>();
            list.Insert(0,new Data.Model.Studio());

            cmbStudio.DisplayMember = "NazivStudija";
            cmbStudio.ValueMember = "StudioId";

            cmbStudio.DataSource = list;
        }

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaslov.Text))
            {
                err.SetError(txtNaslov, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtNaslov, null);
            }
        }

        private void txtSadrzaj_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSadrzaj.Text))
            {
                err.SetError(txtSadrzaj, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtSadrzaj, null);
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
