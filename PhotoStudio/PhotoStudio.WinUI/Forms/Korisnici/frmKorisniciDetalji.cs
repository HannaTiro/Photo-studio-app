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
    public partial class frmKorisniciDetalji : Form
    {
        private readonly APIService _apiService = new APIService("Korisnik");
        private int? _korisnik = null;
        public frmKorisniciDetalji(int korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            if(_korisnik.HasValue)
            {
                var podaci = await _apiService.GetById<Data.Model.Korisnik>(_korisnik);
                txtIme.Text = podaci.Ime;
                txtPrezime.Text = podaci.Prezime;
                txtBroj.Text = podaci.Telefon;
                txtEmail.Text = podaci.Email;
                txtGrad.Text = podaci.Grad.NazivGrada;
               
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
