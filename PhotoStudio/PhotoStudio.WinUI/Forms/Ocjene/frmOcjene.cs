using PhotoStudio.Data.Requests.Rejting;
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

namespace PhotoStudio.WinUI.Forms.Ocjene
{
    public partial class frmOcjene : Form
    {
        protected APIService _serviceRejting = new APIService("Rejting");
        public frmOcjene()
        {
            InitializeComponent();
        }

        private async void frmOcjene_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            var podaci = await _serviceRejting.Get<List<Data.Model.Rejting>>(null);
            List<frmRejtingVM> lista = new List<frmRejtingVM>();
            foreach (var x in podaci)
            {
                frmRejtingVM forma = new frmRejtingVM
                {
                    RejtingId=x.RejtingId,
                    Ocjena=x.Ocjena,
                    FotografId=x.Fotograf.FotografId,
                    ImeFotografa=x.Fotograf.Ime,
                    PrezimeFotografa=x.Fotograf.Prezime,
                    KorisnikId=x.Korisnik.KorisnikId,
                    ImeKorisnika=x.Korisnik.Ime,
                    PrezimeKorisnika=x.Korisnik.Prezime


                };
                lista.Add(forma);

            }
            dgvRejting.AutoGenerateColumns = false;
            dgvRejting.DataSource = lista;

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new RejtingSearchRequest()
            {
                ImeFotografa = txtIme.Text,
                PrezimeFotografa = txtPrezime.Text

            };
            if (txtOcjena.Text != "")
            {
                search.Ocjena = int.Parse(txtOcjena.Text);
            }

            var podaci = await _serviceRejting.Get<List<Data.Model.Rejting>>(search);
            List<frmRejtingVM> lista = new List<frmRejtingVM>();
            foreach (var x in podaci)
            {
                frmRejtingVM forma = new frmRejtingVM
                {
                    FotografId= (int)x.FotografId,
                    ImeFotografa=x.Fotograf.Ime,
                    PrezimeFotografa=x.Fotograf.Prezime,
                    Ocjena=x.Ocjena,
                    ImeKorisnika=x.Korisnik.Ime,
                    PrezimeKorisnika=x.Korisnik.Prezime,
                    KorisnikId=x.Korisnik.KorisnikId,
                    RejtingId=x.RejtingId
                };
                lista.Add(forma);
            }
            dgvRejting.AutoGenerateColumns = false;
            dgvRejting.DataSource = lista;
            if(lista.Count==0)
            {
                MessageBox.Show("Nema rezultata pretrage", "Poruka", MessageBoxButtons.OK);
            }
        }

        private void dgvRejting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var ocjena = dgvRejting.SelectedRows[0].Cells[0].Value;
            
            var rez = ocjena.ToString();
            frmOcjenaDetalji forma = new frmOcjenaDetalji(int.Parse(rez));
            forma.Show();
        }
    }
}
