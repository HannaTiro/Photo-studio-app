using PhotoStudio.Data.Requests.Rezervacija;
using PhotoStudio.Data.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudio.WinUI.Forms.Rezervacije
{
    public partial class frmRezervacije : Form
    {
        protected APIService _servisKorisnik = new APIService("Korisnik");
        protected APIService _servisRezervacija = new APIService("Rezervacija");



        public frmRezervacije()
        {
            InitializeComponent();
        }

        private async  void frmRezervacije_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            var podaci = await _servisRezervacija.Get<List<Data.Model.Rezervacija>>(null);

            var lista = new List<frmBookingVM>();
            foreach (var x in podaci)
            {
                frmBookingVM forma = new frmBookingVM
                {
                    RezervacijaId=x.RezervacijaId,
                    DatumDo=x.DatumDo.Value.Date,
                    DatumOd=x.DatumOd.Value.Date,
                    Ime=x.Fotograf.Ime,
                    Prezime=x.Fotograf.Prezime
                };
                lista.Add(forma);
            }
            dgvRezervacije.AutoGenerateColumns = false;
            dgvRezervacije.DataSource = lista;

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new RezervacijaSearchRequest()
            {
                ImeFotografa = txtIme.Text,
                PrezimeFotografa = txtPrezime.Text,
                DatumDo = dtpDo.Value.Date,
                DatumOd = dtpOd.Value.Date,
                



            };
            if(search.DatumDo.Value.Date<=search.DatumOd.Value.Date)
            {
                MessageBox.Show("Datum početka mora biti manji od datuma završetka", "Greška", MessageBoxButtons.OK);
            }
            var podaci = await _servisRezervacija.Get<List<Data.Model.Rezervacija>>(search);
            List<frmBookingVM> lista = new List<frmBookingVM>();
            foreach (var x in podaci)
            {
                frmBookingVM forma = new frmBookingVM
                {
                    RezervacijaId=x.RezervacijaId,
                    DatumDo=x.DatumDo,
                    DatumOd=x.DatumOd,
                    Ime=x.Fotograf.Ime,
                    Prezime=x.Fotograf.Prezime
                };
                lista.Add(forma);
            }
            dgvRezervacije.AutoGenerateColumns = false;
            dgvRezervacije.DataSource = lista;
            if(lista.Count==0)
            {
                MessageBox.Show("Nema rezultata pretrage", "Poruka", MessageBoxButtons.OK);

            }
        }

    

        private void dgvRezervacije_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var rezervacija = dgvRezervacije.SelectedRows[0].Cells[0].Value;
           // MessageBox.Show(rezervacija.ToString());
            var rezultat = rezervacija.ToString();
            frmRezervacijaDetalji forma = new frmRezervacijaDetalji(int.Parse(rezultat));
            forma.Show();
        }
    }
}
