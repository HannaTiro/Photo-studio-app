using PhotoStudio.Data.Model;
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

namespace PhotoStudio.WinUI.Forms
{
    public partial class frmLogin : Form
    {
        private readonly APIService aPIService = new APIService("Korisnik");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;

               
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Sva polja su obavezna", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var request = new KorisnikSearchRequest
                {
                    Username = txtUsername.Text
                };
                var result = await aPIService.Get<List<Korisnik>>();

                if (result.Count == 0)
                {
                    MessageBox.Show("Korisnik ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    frmPocetna frm = new frmPocetna();
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pogrešan username ili password", MessageBoxButtons.OK);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
