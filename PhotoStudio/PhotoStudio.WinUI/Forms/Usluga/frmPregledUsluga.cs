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
    public partial class frmPregledUsluga : Form
    {
        private readonly APIService _apiService = new APIService("Usluga");

        public frmPregledUsluga()
        {
            InitializeComponent();
        }

        private async void frmPregledUsluga_Load(object sender, EventArgs e)
        {
            var podaci = await _apiService.Get<List<UslugaRequest>>(null);
            dgvUsluge.AutoGenerateColumns = false;
            dgvUsluge.DataSource = podaci;
        }

        private async  void btnSearch_Click(object sender, EventArgs e)
        {
            var pretraga = new UslugaSearchRequest()
            {
                 Naziv= txtNaziv.Text
               
            };
            var podaci = await _apiService.Get<List<Data.Model.Usluga>>(pretraga);
            dgvUsluge.AutoGenerateColumns = false;
            dgvUsluge.DataSource = podaci;

            if (podaci.Count == 0)
            {
                MessageBox.Show("Nema rezultata pretrage", "Poruka", MessageBoxButtons.OK);
            }
        }
    }
}
