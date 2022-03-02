using PhotoStudio.Data.Model;
using PhotoStudio.Data.Requests.Korisnik;
using PhotoStudio.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;



namespace PhotoStudio.MobileApp.ViewModels
{
   public  class RegistracijaViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnik");
      

        public ICommand RegisterCommand { get; set; }
        public RegistracijaViewModel()
        {
            RegisterCommand = new Command(async () => await Registracija());
        }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
           public int GradId = 1;
        //samo su dva grada u bazi, nema smisla da se prikazuje lista gradova odakle dolazi korisnik. On je predvidjen za uposlenike da
        //se vidi u kojem studiju rade 

        public async Task Registracija()
        {
            try
            {
                if (Password != PasswordConfirm)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti dva ista passworda", "OK");
                    return;
                }
            

                if (string.IsNullOrEmpty(Ime) || string.IsNullOrEmpty(Prezime) || string.IsNullOrEmpty(Telefon) || string.IsNullOrEmpty(Email)
                    || string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(PasswordConfirm))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Sva polja su obavezna", "OK");
                    return;
                }

                //var korisnici = await _service.GetProvjera<Data.Model.Korisnik>(new KorisnikSearchRequest
                //{
                //    Username = Username
                //});
                var korisnici = await _service.Get<List<Data.Model.Korisnik>>(null);

                //if (korisnici != null)
                //{
                //    await Application.Current.MainPage.DisplayAlert("Greška", "Username je zauzet, unesite drugo ime", "OK");
                //    return;

                //}
                foreach (var item in korisnici)
                {
                    if (item.Username == Username)
                    {
                        await Application.Current.MainPage.DisplayAlert("Greška", "Username je zauzet, unesite drugo ime", "OK");
                        return;
                    }
                    if(item.Email==Email)
                    {
                        await Application.Current.MainPage.DisplayAlert("Greška", "Email je već u upotrebi", "OK");
                        return;
                    }
                    if (item.Telefon == Telefon)
                    {
                        await Application.Current.MainPage.DisplayAlert("Greška", "Uneseni broj telefona je već u upotrebi", "OK");
                        return;
                    } 


                }


                var request = new KorisnikUpsert
                {
                    Ime = Ime,
                    Prezime = Prezime,
                    Telefon = Telefon,
                    Email = Email,
                    GradId=GradId,
                    Username = Username,
                    Password = Password,
                    PasswordConfirm = PasswordConfirm,
                    TipKorisnikaId = 2
                };

                //await _service.SingUp<Data.Model.Korisnik>(request);

                await _service.Insert<Data.Model.Korisnik>(request);

                await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste izvršili registraciju", "Logiraj se");
                await Application.Current.MainPage.Navigation.PushModalAsync(new LoginPage());
            }
            catch (Exception err)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Registracija neuspješna", "OK");
            }
        }

    }
}
