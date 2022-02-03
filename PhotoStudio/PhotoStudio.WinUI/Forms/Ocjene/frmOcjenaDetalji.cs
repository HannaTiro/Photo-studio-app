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
    public partial class frmOcjenaDetalji : Form
    {
        protected APIService _serviceRejting = new APIService("Rejting");
        private int? _id = null;
        public frmOcjenaDetalji(int? id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmOcjenaDetalji_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            if(_id.HasValue)
            {
                var podaci = await _serviceRejting.GetById<Data.Model.Rejting>(_id);
                txtKorisnikId.Text = podaci.Korisnik.KorisnikId.ToString();
                txtImeKorisnika.Text = podaci.Korisnik.Ime;
                txtPrezimeFotografa.Text = podaci.Korisnik.Prezime;
                txtOcjenaKorisnika.Text = podaci.Ocjena.ToString();
                txtFotografId.Text = podaci.Fotograf.FotografId.ToString();
                txtImeFotografa.Text= podaci.Fotograf.Ime;
                txtPrezimeKorisnika.Text = podaci.Korisnik.Prezime;

                var ocjeneSvih = await _serviceRejting.Get<List<Data.Model.Rejting>>(null);
                int brojac = 0;
                int suma = 0;
                float prosjek = 0;
                foreach (var x in ocjeneSvih)
                {
                    if(podaci.Fotograf.FotografId==x.FotografId)
                    {
                        suma += x.Ocjena;
                        brojac++;
                    }
                }
                prosjek = suma / brojac;
                txtProsjecna.Text = prosjek.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
