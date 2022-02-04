using PhotoStudio.Data.Requests.Komentar;
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
    public partial class frmKomentarDetalji : Form
    {
        APIService _serviceKomentar = new APIService("Komentar");
        private int? _id = null;
        public frmKomentarDetalji(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmKomentarDetalji_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
           if(_id.HasValue)
            {
                var podaci = await _serviceKomentar.GetById<KomentarRequest>(_id);
                txtKorisnikId.Text = podaci.Korisnik.KorisnikId.ToString();
                txtImeKorisnika.Text = podaci.Korisnik.Ime;
                txtPrezimeKorisnika.Text = podaci.Korisnik.Prezime;

                txtFotografId.Text = podaci.Fotograf.FotografId.ToString();
                txtImeFotografa.Text = podaci.Fotograf.Ime;
                txtPrezimeFotografa.Text = podaci.Fotograf.Prezime;

                txtKomentarId.Text = podaci.KomentarId.ToString();
                txtDatum.Text = podaci.Datum.Value.Date.ToString();
                txtOpis.Text = podaci.Opis;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
