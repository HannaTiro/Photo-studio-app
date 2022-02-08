using PhotoStudio.Data.Model;
using PhotoStudio.Data.Requests.Fotograf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudio.WinUI.Forms.Fotografi
{
    public partial class frmUpdateFotografa : Form
    {
        protected APIService _servisFotograf = new APIService("Fotograf");
        protected APIService _servisTipFotografa = new APIService("TipFotografa");
        private int? _fotograf;
        public frmUpdateFotografa(int? fotograf)
        {
            InitializeComponent();
            _fotograf = fotograf;
        }

        private async void frmUpdateFotografa_Load(object sender, EventArgs e)
        {
            
            LoadData();

        }

        private async  void LoadData()
        {
            await LoadTip();
            if(_fotograf.HasValue)
            {
                
                var podaci = await _servisFotograf.GetById<Data.Model.Fotograf>(_fotograf);
                txtIme.Text = podaci.Ime;
                txtPrezime.Text = podaci.Prezime;
                txtCijena.Text = podaci.DnevnaCijena.ToString();
                cbDostupan.Checked = podaci.Status.GetValueOrDefault(false);
                txtOpis.Text = podaci.Opis;
               
            }
        }

        private async Task LoadTip()
        {
            var lista = await _servisTipFotografa.Get<List<Data.Model.TipFotografa>>();
            lista.Insert(0, new Data.Model.TipFotografa());
            cmbTipFotografa.ValueMember = "TipFotografaId";
            cmbTipFotografa.DisplayMember = "Naziv";
            cmbTipFotografa.DataSource = lista;
        }
        FotografUpsert request = new FotografUpsert();
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (_fotograf.HasValue)
            {
                request.Ime = txtIme.Text;
                request.Prezime = txtPrezime.Text;
                request.Status = cbDostupan.Checked;
                request.Opis = txtOpis.Text;
                request.DnevnaCijena = double.Parse(txtCijena.Text);
                var tipId = cmbTipFotografa.SelectedValue;
                if (int.TryParse(tipId.ToString(), out int TipId))
                {
                    request.TipFotografaId = TipId;
                }
                // request.Slika = pbSlika.Image;



                await _servisFotograf.Update<Fotograf>(_fotograf,request);
                MessageBox.Show("Podaci o fotografu su izmijenjeni", "Poruka", MessageBoxButtons.OK);
                this.Close();
            }
        }
        
        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Slika = file;
                txtSlika.Text = fileName;

                Image img = Image.FromFile(fileName);
                pbSlika.Image = img;
                pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
