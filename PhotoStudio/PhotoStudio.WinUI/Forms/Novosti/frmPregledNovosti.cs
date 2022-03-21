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
    public partial class frmPregledNovosti : Form
    {
        private readonly APIService _apiService = new APIService("Novost");

        public frmPregledNovosti()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var pretraga = new NovostSearchRequest()
            {
               Naslov=txtNaslov.Text,
               Sadrzaj=txtSadrzaj.Text,
               DatumObjave=txtDatum.Text
            };
            var podaci = await _apiService.Get<List<Data.Model.Novost>>(pretraga);
            dgvNovosti.AutoGenerateColumns = false;
            dgvNovosti.DataSource = podaci;

            if (podaci.Count == 0)
            {
                MessageBox.Show("Nema rezultata pretrage", "Poruka", MessageBoxButtons.OK);
            }
        }

        private async void frmPregledNovosti_Load(object sender, EventArgs e)
        {
            var podaci = await _apiService.Get<List<NovostRequest>>(null);
            dgvNovosti.AutoGenerateColumns = false;
            dgvNovosti.DataSource = podaci;
        }
    }
}
