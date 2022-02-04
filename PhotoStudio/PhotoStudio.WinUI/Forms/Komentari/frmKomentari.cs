using PhotoStudio.Data.Requests.Komentar;
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

namespace PhotoStudio.WinUI.Forms.Komentari
{
    public partial class frmKomentari : Form
    {
        APIService _serviceKomentar = new APIService("Komentar");
       
        public frmKomentari()
        {
            InitializeComponent();
        }

        private async void frmKomentari_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            var podaci = await _serviceKomentar.Get<List<Data.Model.Komentar>>(null);
            List<frmKomentarVM> lista = new List<frmKomentarVM>();
            foreach (var x in podaci)
            {
                frmKomentarVM forma = new frmKomentarVM
                {
                    FotografId= x.Fotograf.FotografId,
                    ImeKorisnika=x.Korisnik.Ime,
                    PrezimeKorisnika=x.Korisnik.Prezime,
                    KomentarId=x.KomentarId,
                    KorisnikId=x.Korisnik.KorisnikId,
                    Opis=x.Opis
                };
                lista.Add(forma);
            }
            dgvKomentari.AutoGenerateColumns = false;
            dgvKomentari.DataSource = lista;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new KomentarSearchRequest()
            {
                FotografId=int.Parse(txtFotografId.Text),
                ImeKorisnika=txtImeKorisnika.Text,
                PrezimeKorisnika=txtPrezimeKorisnika.Text
            };
            var podaci = await _serviceKomentar.Get<List<Data.Model.Komentar>>(search);
            List<frmKomentarVM> lista = new List<frmKomentarVM>();

            foreach (var x in podaci)
            {
                var forma = new frmKomentarVM
                {
                    FotografId=x.Fotograf.FotografId,
                    ImeKorisnika=x.Korisnik.Ime,
                    PrezimeKorisnika=x.Korisnik.Prezime,
                    KomentarId=x.KomentarId,
                    KorisnikId=x.Korisnik.KorisnikId,
                    Opis=x.Opis
                };
                lista.Add(forma);
            }
            dgvKomentari.AutoGenerateColumns = false;
            dgvKomentari.DataSource = lista;
            if(lista.Count==0)
            {
                MessageBox.Show("Nema rezultata pretrage", "Poruka", MessageBoxButtons.OK);
            }
        }

        private void dgvKomentari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var komentar = dgvKomentari.SelectedRows[0].Cells[0].Value;

            var rez = komentar.ToString();
            frmKomentarDetalji forma = new frmKomentarDetalji(int.Parse(rez));
            forma.Show();
        }
    }
}
