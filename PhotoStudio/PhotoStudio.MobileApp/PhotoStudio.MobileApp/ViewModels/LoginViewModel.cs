using Flurl.Http;
using PhotoStudio.Data.Model;
using PhotoStudio.Data.Requests.Korisnik;
using PhotoStudio.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PhotoStudio.MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

       
        private readonly APIService service = new APIService("Korisnik");
        public ICommand LoginCommand { get; set; }
        public LoginViewModel()
        {

            LoginCommand = new Command(async () => await Login());
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }




        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Sva polja su obavezna", "OK");
                return;
            }

            try
            {
                List<Data.Model.Korisnik> list = await service.Get<List<Data.Model.Korisnik>>(new KorisnikSearchRequest
                {
                    Username = Username
                });


                if (list.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Neispravan username ili password", "Pokušaj ponovo");
                    return;
                }

                foreach (var item in list)
                {
                    if (item.Username == Username)
                    {
                        APIService.KorisnikId = item.KorisnikId;
                    }
                }
                //await _service.Get<dynamic>(null);
                Application.Current.MainPage = new PocetniPage(); //pocetna stranica
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Neispravan username ili password", "Pokušaj ponovo");
            }
            //try
            //{
            //    Korisnik korisnik = await service.Login<Korisnik>(Username, Password);

            //    if (korisnik != null)
            //    {
            //        APIService.Username = Username;
            //        APIService.Password = Password;
            //        //PrijavljeniKlijentService.PrijavljeniKlijent = korisnik;
            //        await Application.Current.MainPage.DisplayAlert("Dobrodosli", "Dobrodosli " + korisnik.Ime + " " + korisnik.Prezime, "OK");
            //        Application.Current.MainPage = new AboutPage();
            //    }
            //    else
            //    {
            //        await Application.Current.MainPage.DisplayAlert("Greska", "Pogresno unesen username ili password", "OK");
            //    }
            //} 
            //catch(Exception ex)
            //{
            //    await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");
            //}
        }
        //async Task Login()
        //{
        //    IsBusy = true;
        //    APIService.Username = Username;
        //    APIService.Password = Password;

        //    try
        //    {
        //        await service.Get<dynamic>(null);
        //        Application.Current.MainPage = new AboutPage();
        //    }
        //    catch (Exception ex)
        //    {
        //        await Application.Current.MainPage.DisplayAlert("Greska", "Pogresno unesen username ili password", "OK");
        //    }
        //}





    }
}
