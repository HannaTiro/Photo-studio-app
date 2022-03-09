using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PhotoStudio.MobileApp.ViewModels
{
   public  class KorisnikProfilViewModel:BaseViewModel
    {
        private readonly APIService _korisnikService = new APIService("Korisnik");
        public ICommand InitCommand { get; set; }
        public ICommand LogoutCommand { get {
                return new Command(() =>
                  {
                      APIService.Username = "";
                      APIService.Password = "";
                      APIService.KorisnikId = 0;
                   });

            } 
        }
        public string _ime = string.Empty;
        public string ImeKorisnika { get { return _ime; } set { SetProperty(ref _ime, value); } }
        public string _prezime = string.Empty;
        public string PrezimeKorisnika { get { return _prezime; } set { SetProperty(ref _prezime, value); } }

        public string _username = string.Empty;
        public string Username { get { return _username; } set { SetProperty(ref _username, value); } }
        public string _email = string.Empty;
        public string Email { get { return _email; } set { SetProperty(ref _email, value); } }

        public string _telefon = string.Empty;
        public string Telefon { get { return _telefon; } set { SetProperty(ref _telefon, value); } }
        public string _grad = string.Empty;
        public string Grad { get { return _grad; } set { SetProperty(ref _grad, value); } }




        public KorisnikProfilViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }
        public async Task Init()
        {
            var korisnik = await _korisnikService.GetById<Data.Model.Korisnik>(APIService.KorisnikId);

            PrezimeKorisnika = korisnik.Prezime;
            Telefon = korisnik.Telefon;
            Grad = korisnik.Grad.NazivGrada;
            Email = korisnik.Email;
            ImeKorisnika = korisnik.Ime;
        }
        

    }
}
