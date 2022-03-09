using PhotoStudio.Data.Requests.Rezervacija;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PhotoStudio.MobileApp.ViewModels
{
   public  class MojeOcjeneViewModel:BaseViewModel
    {
        private readonly APIService _korisnikService = new APIService("Korisnik");

        private readonly APIService _rezervacijaService = new APIService("Rezervacija");
        public ObservableCollection<Data.Model.Rezervacija> ListaRezervacija { get; set; } = new ObservableCollection<Data.Model.Rezervacija>();
        public Data.Model.Korisnik _korisnk;
        public ICommand InitCommand { get; set; }
        public MojeOcjeneViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public async Task Init()
        {
            var korisnik = await _korisnikService.GetById<Data.Model.Korisnik>(APIService.KorisnikId);
            _korisnk = korisnik;
            var request = new RezervacijaSearchRequest
            {
                KorisnikId = _korisnk.KorisnikId
            };
            ListaRezervacija.Clear();
            var rezervacije = await _rezervacijaService.Get<List<Data.Model.Rezervacija>>(request);
            foreach (var item in rezervacije)
            {
                if (item.isOcijenjeno == false && item.DatumDo.Value <= DateTime.Now.Date)
                {
  
                    ListaRezervacija.Add(item);
                }

            }
            if (ListaRezervacija.Count == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Poruka", "Ocjene za rezervacije možete ostaviti tek kada one isteknu. Hvala. ", "OK");

            }

        }


    }
}
