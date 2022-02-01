using PhotoStudio.Data.Requests.Fotograf;
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

namespace PhotoStudio.WinUI.Forms.Fotografi
{
    public partial class frmFotografi : Form
    {
        private readonly APIService _apiService = new APIService("Fotograf");
        public frmFotografi()
        {
            InitializeComponent();
        }

        private async void frmFotografi_Load(object sender, EventArgs e)
        {
            var podaci = await _apiService.Get<List<Data.Model.Fotograf>>(null);
            List<frmFotografiVM> lista = new List<frmFotografiVM>();
            foreach (var item in podaci)
            {
                frmFotografiVM forma = new frmFotografiVM
                {
                    FotografId=item.FotografId,
                    Ime=item.Ime,
                    Prezime=item.Prezime,
                    Slika=item.Slika,
                    TipFotografa=item.TipFotografa.Naziv,
                    DnevnaCijena=item.DnevnaCijena.Value,
                    //Status=item.Status.ToString(),
                    Opis=item.Opis

                };
                lista.Add(forma);
            }
            dgvFotografi.AutoGenerateColumns = false;
            dgvFotografi.DataSource = lista;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var pretraga = new FotografSearchRequest()
            {
                Ime=txtIme.Text,
                Prezime=txtPrezime.Text,
                TipFotografa=txtTipFotografa.Text
            };
            var podaci = await _apiService.Get<List<Data.Model.Fotograf>>(pretraga);
            var lista = new List<frmFotografiVM>();

            foreach (var item in podaci)
            {
                var forma = new frmFotografiVM
                {
                    FotografId=item.FotografId,
                    Ime=item.Ime,
                    Prezime=item.Prezime,
                    Slika=item.Slika,
                    TipFotografa=item.TipFotografa.Naziv,
                    DnevnaCijena=item.DnevnaCijena.Value,
                   // Status = item.Status.ToString(),
                   Opis=item.Opis

                };
                lista.Add(forma);
            }
            dgvFotografi.AutoGenerateColumns = false;
            dgvFotografi.DataSource = lista;
            if(lista.Count==0)
            {
                MessageBox.Show("Nema rezultata pretrage", "Poruka", MessageBoxButtons.OK);
            }    
        }

        private void dgvFotografi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var fotograf = dgvFotografi.SelectedRows[0].Cells[0].Value;
            // var korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem;
            // MessageBox.Show(korisnik.ToString());
            var rez = fotograf.ToString();
            frmFotografDetalji forma = new frmFotografDetalji(int.Parse(rez));
            forma.Show();
        }
    }
}
