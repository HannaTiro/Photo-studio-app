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
    public partial class frmFotografDetalji : Form
    {
        private readonly APIService _apiService = new APIService("Fotograf");
        private int? _fotograf = null;
        public frmFotografDetalji(int fotograf)
        {
            InitializeComponent();
            _fotograf = fotograf;
        }

        private async void frmFotografDetalji_Load(object sender, EventArgs e)
        {
            if(_fotograf.HasValue)
            {
                var podaci = await _apiService.GetById<Data.Model.Fotograf>(_fotograf);
                txtIme.Text = podaci.Ime;
                txtPrezime.Text = podaci.Prezime;
                txtCijena.Text = podaci.DnevnaCijena.Value.ToString();
                txtTipFotografa.Text = podaci.TipFotografa.Naziv;
                txtOpis.Text = podaci.Opis;
                if(podaci.Status.Value==false)
                {
                    txtStatus.Text = "Slobodan";
                }
                else
                {
                    txtStatus.Text = "Zauzet";
                }
               // txtStatus.Text = podaci.Status.Value.ToString();

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            frmUpdateFotografa forma = new frmUpdateFotografa(_fotograf);
            forma.Show();
        }
    }
}
