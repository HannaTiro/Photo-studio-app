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
    public partial class frmPregledOpreme : Form
    {
        private readonly APIService _apiService = new APIService("Oprema");

        public frmPregledOpreme()
        {
            InitializeComponent();
        }

        private async void frmPregledOpreme_Load(object sender, EventArgs e)
        {
            var podaci = await _apiService.Get<List<OpremaRequest>>(null);
            dgvOprema.AutoGenerateColumns = false;
            dgvOprema.DataSource = podaci;
        }

        private async  void btnSearch_Click(object sender, EventArgs e)
        {
            var pretraga = new OpremaSearchRequest()
            {
                Naziv = txtNaziv.Text,
                Opis = txtOpis.Text,
                Studio = txtStudio.Text
            };
            var podaci = await _apiService.Get<List<Data.Model.Oprema>>(pretraga);
            dgvOprema.AutoGenerateColumns = false;
            dgvOprema.DataSource = podaci;

            if (podaci.Count == 0)
            {
                MessageBox.Show("Nema rezultata pretrage", "Poruka", MessageBoxButtons.OK);
            }
        }

        private void dgvOprema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var komentar = dgvOprema.SelectedRows[0].Cells[0].Value;

            var rez = komentar.ToString();
            frmOpremaDetalji forma = new frmOpremaDetalji(int.Parse(rez));
            forma.Show();
        }
    }
}
