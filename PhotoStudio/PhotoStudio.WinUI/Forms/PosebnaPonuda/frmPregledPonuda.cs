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
    public partial class frmPregledPonuda : Form
    {
        private readonly APIService _apiService = new APIService("PosebnaPonuda");

        public frmPregledPonuda()
        {
            InitializeComponent();
        }

        private async void frmPregledPonuda_Load(object sender, EventArgs e)
        {
            var podaci = await _apiService.Get<List<PosebnaPonudaRequest>>(null);
            dgvPonude.AutoGenerateColumns = false;
            dgvPonude.DataSource = podaci;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var pretraga = new PosebnaPonudaSearchRequest()
            {
                NazivPonude = txtNazivPonude.Text,
                Opis = txtOpis.Text
               
            };
            var podaci = await _apiService.Get<List<Data.Model.PosebnaPonuda>>(pretraga);
            dgvPonude.AutoGenerateColumns = false;
            dgvPonude.DataSource = podaci;

            if (podaci.Count == 0)
            {
                MessageBox.Show("Nema rezultata pretrage", "Poruka", MessageBoxButtons.OK);
            }
        }
    }
}
