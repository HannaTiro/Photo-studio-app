using PhotoStudio.Data.Requests.Korisnik;
using PhotoStudio.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PhotoStudio.MobileApp.ViewModels
{
   public  class UrediKorisnikProfilViewModel:BaseViewModel
    {
        private readonly APIService _korisnikService = new APIService("Korisnik");
        public ICommand InitCommand { get; set; }
        public ICommand SpasiIzmjeneCommand { get; set; }
        public Data.Model.Korisnik _korisnik { get; set; }
        public UrediKorisnikProfilViewModel()
        {
            InitCommand= new Command(async () => await Init());
            SpasiIzmjeneCommand = new Command(async () => await SpasiIzmjene());
        }

        public string _ime = string.Empty;
        public string ImeKorisnika { get { return _ime; } set { SetProperty(ref _ime, value); } }
        public string _prezime = string.Empty;
        public string PrezimeKorisnika { get { return _prezime; } set { SetProperty(ref _prezime, value); } }

     
        public string _email = string.Empty;
        public string Email { get { return _email; } set { SetProperty(ref _email, value); } }

        public string _telefon = string.Empty;
        public string Telefon { get { return _telefon; } set { SetProperty(ref _telefon, value); } }

        public string _password = string.Empty;
        public string Password { get { return _password; } set { SetProperty(ref _password, value); } }

        public string _passwordConfirm = string.Empty;
        public string PasswordConfirm { get { return _passwordConfirm; } set { SetProperty(ref _passwordConfirm, value); } }

        

       

        public async Task Init()
        {
            var korisnik = await _korisnikService.GetById<Data.Model.Korisnik>(APIService.KorisnikId);
            _korisnik = korisnik;

            ImeKorisnika = korisnik.Ime;
            PrezimeKorisnika = korisnik.Prezime;
            Telefon = korisnik.Telefon;
            Email = korisnik.Email;
            
        }
        public async Task SpasiIzmjene()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ImeKorisnika) || string.IsNullOrWhiteSpace(PrezimeKorisnika) || 
                    string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Telefon))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Sva polja su obavezna", "OK");
                    return;
                }
                 var Korisnik = await _korisnikService.GetById<Data.Model.Korisnik>(APIService.KorisnikId);
                _korisnik = Korisnik;
                var request = new KorisnikUpsert
                {
                    Ime=ImeKorisnika,
                    Prezime=PrezimeKorisnika,
                    Email=Email,
                    Telefon=Telefon,
                    Username=APIService.Username,
                    Password=APIService.Password,
                    PasswordConfirm=APIService.Password,
                    TipKorisnikaId=2,
                    GradId=_korisnik.Grad.GradId
                };
               
                var novi = await _korisnikService.Update<Data.Model.Korisnik>(APIService.KorisnikId, request);
                await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste izmijenili informacije svog progila, molimo Vas da ponovo izvršite prijavu. Hvala.  ", "OK");
                await Application.Current.MainPage.Navigation.PushModalAsync(new LoginPage());
            }
            catch( Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Neuspješno", "OK");

            }
        }
    }
}
