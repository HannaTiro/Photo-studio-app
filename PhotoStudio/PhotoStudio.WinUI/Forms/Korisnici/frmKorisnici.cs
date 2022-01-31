using PhotoStudio.Data.Requests.Korisnik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudio.WinUI.Forms.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _apiService = new APIService("Korisnik");
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private async void frmKorisnici_Load(object sender, EventArgs e)
        {
            var podaci = await _apiService.Get<List<KorisnikRequest>>(null);
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = podaci;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var pretraga = new KorisnikSearchRequest()
            {
                Ime=txtIme.Text,
                Prezime=txtPrezime.Text,
                Email=txtEmail.Text
            };
            var podaci = await _apiService.Get<List<Data.Model.Korisnik>>(pretraga);
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = podaci;

            if(podaci.Count==0)
            {
                MessageBox.Show("Nema rezultata pretrage", "Upozorenje", MessageBoxButtons.OK);
            }
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var korisnik = dgvKorisnici.SelectedRows[0].Cells[0].Value;
            // var korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem;
            // MessageBox.Show(korisnik.ToString());
            var rez = korisnik.ToString();
           frmKorisniciDetalji forma = new frmKorisniciDetalji(int.Parse(rez));
            forma.Show();
            

        }
    }
}
