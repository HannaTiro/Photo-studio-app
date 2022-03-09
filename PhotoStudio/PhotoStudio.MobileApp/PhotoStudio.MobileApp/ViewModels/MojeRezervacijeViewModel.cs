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
    public class MojeRezervacijeViewModel: BaseViewModel
    {
        private readonly APIService _korisnikService = new APIService("Korisnik");
        private readonly APIService _rezervacijaService = new APIService("Rezervacija");
        public Data.Model.Korisnik _korisnik { get; set; }
        public ObservableCollection<Data.Model.Rezervacija> ListaRezervacija { get; set; } = new ObservableCollection<Data.Model.Rezervacija>();
        public ICommand InitCommand { get; set; }
      //  public ICommand SortCommand { get; set; } //dodati za filter placene/neplacene 

        public MojeRezervacijeViewModel()
        {
            InitCommand = new Command(async () => await Init());
          //SortCommand = new Command(async () => await Sort());


        }
        public async Task Init()
        {
            var korisnik = await _korisnikService.GetById<Data.Model.Korisnik>(APIService.KorisnikId);
            _korisnik = korisnik;
            var request = new RezervacijaSearchRequest
            {
                KorisnikId = _korisnik.KorisnikId
            };
            ListaRezervacija.Clear(); //ne dupla listu rezervacija kada se učitava više puta u jednoj pokrenutoj sesiji 
            var KorisnikRezervacije = await _rezervacijaService.Get<List<Data.Model.Rezervacija>>(request);
            foreach (var i in KorisnikRezervacije)
            {
                ListaRezervacija.Add(i);
            }
            if(ListaRezervacija.Count==0)
            {
                await Application.Current.MainPage.DisplayAlert("Poruka", "Nemate izvršenih rezervacija", "OK");
            }
        }
        //public async Task Sort()
        //{

        //    var request = new BookingSearchRequest
        //    {
        //       isPlaceno=isPlaceno
        //    };

        //    var list = await _rezervacijaService.Get<IEnumerable<Data.Model.Rezervacija>>(request);
        //    ListaRezervacija.Clear();

        //    foreach (var item in list)
        //    {

        //        ListaRezervacija.Add(item);
        //    }
        //    if (ListaRezervacija.Count == 0)
        //    {
        //        await Application.Current.MainPage.DisplayAlert("Poruka", "Nema rezultata pretrage", "OK");
        //    }
        //}


    }
}
