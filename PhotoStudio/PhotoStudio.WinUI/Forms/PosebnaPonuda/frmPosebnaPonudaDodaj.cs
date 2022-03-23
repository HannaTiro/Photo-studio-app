using PhotoStudio.Data.Requests.PosebnaPonuda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudio.WinUI.Forms.PosebnaPonuda
{
    public partial class frmPosebnaPonudaDodaj : Form
    {
        protected APIService _servicePosebnaPonuda = new APIService("PosebnaPonuda");
        protected APIService _serviceStudio = new APIService("Studio");
        public frmPosebnaPonudaDodaj()
        {
            InitializeComponent();
        }

        private async void frmPosebnaPonudaDodaj_Load(object sender, EventArgs e)
        {
            var list = await _serviceStudio.Get<List<Data.Model.Studio>>();
            list.Insert(0, new Data.Model.Studio());

            cmbStudio.DisplayMember = "NazivStudija";
            cmbStudio.ValueMember = "StudioId";

            cmbStudio.DataSource = list;
        }
        PosebnaPonudaUpsert request = new PosebnaPonudaUpsert();
        private async  void btnDodaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                request.NazivPonude = txtNaziv.Text;
                request.Opis = txtOpis.Text;
                var odabraniStudio = cmbStudio.SelectedValue;
                if (int.TryParse(odabraniStudio.ToString(), out int studio))
                {
                    request.StudioId = studio;
                }
                var search = new PosebnaPonudaSearchRequest
                {
                    NazivPonude = txtNaziv.Text,
                    StudioId = request.StudioId,
                    Opis = txtOpis.Text
                };
                var listaPonuda = await _servicePosebnaPonuda.Get<List<Data.Model.PosebnaPonuda>>(search);
                if (listaPonuda.Count >= 1)
                {
                    MessageBox.Show("Tu novost ste već objavili u ovom studiju", "Greška", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    await _servicePosebnaPonuda.Insert<Data.Model.PosebnaPonuda>(request);
                    MessageBox.Show("Uspješno ste dodali novu ponudu", "Poruka", MessageBoxButtons.OK);
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
