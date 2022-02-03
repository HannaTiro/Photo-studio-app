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
    public partial class frmRezervacijaDetalji : Form
    {
        protected APIService _servisRezervacija = new APIService("Rezervacija");
        private int? _id = null;
        public frmRezervacijaDetalji(int? id)
        {
            InitializeComponent();
            _id = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void frmRezervacijaDetalji_Load(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                var rezervacija = await _servisRezervacija.GetById<Data.Model.Rezervacija>(_id);
                txtImeKorisnika.Text = rezervacija.Korisnik.Ime;
                txtKorisnikId.Text = rezervacija.KorisnikId.ToString();
                txtRezervacijaId.Text = rezervacija.RezervacijaId.ToString();
                txtImeFotografa.Text = rezervacija.Fotograf.Ime;
                txtPrezimeFotografa.Text = rezervacija.Fotograf.Prezime;
                dtpDatumOD.Value = rezervacija.DatumOd.Value.Date;
                dtpDatumDO.Value = rezervacija.DatumDo.Value.Date;
                txtVrstaEventa.Text = rezervacija.Fotograf.TipFotografa.Naziv; //pregledati ima li ga na apiju i je li setiran na loadu u vm
                txtCijena.Text = rezervacija.Fotograf.DnevnaCijena.ToString();

                var ukupna = (rezervacija.DatumDo.Value.Date - rezervacija.DatumOd.Value.Date).TotalDays;
                //var dani = ukupna;
                if (ukupna > 0)
                {
                    var cijenaF = rezervacija.Fotograf.DnevnaCijena;
                    ukupna = (double)(ukupna * cijenaF);
                    txtUkupnoCijena.Text = ukupna.ToString("#.##");
                }
                txtUkupnoCijena.Text = rezervacija.Fotograf.DnevnaCijena.ToString();
            }
               
               
            
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
