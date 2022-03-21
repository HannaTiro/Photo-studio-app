using Flurl.Http;
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
                var result = await aPIService.Get<List<Korisnik>>(request);

                if (result is null || result.Count == 0)
                {
                  
                    return;
                }
                else
                {
                    frmPocetna frm = new frmPocetna();
                    frm.Show();
                    this.Hide();
                }
            }
           
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == 401)
                    MessageBox.Show("Neispravno korisničko ime ili lozinka! ", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Došlo je do greške, pokušajte opet! ", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
            }

        }

        
    }
}
