using PhotoStudio.Data.Requests.Rezervacija;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PhotoStudio.MobileApp.ViewModels
{
    public class FotografRezervacijaViewModel: BaseViewModel
    {
        private readonly APIService _fotografService= new APIService("Fotograf");
        private readonly APIService _rezervacijaService = new APIService("Rezervacija");
        private readonly APIService _korisnikService = new APIService("Korisnik");

        public Data.Model.Fotograf _fotograf { get; set; }
        public Data.Model.Korisnik _korisnik { get; set; }

        public ICommand InitCommand { get; set; }
        public ICommand RezervacijaCommand { get; set; }



        public FotografRezervacijaViewModel()
        {
            InitCommand = new Command(async () => await Init());
            RezervacijaCommand = new Command(async () => await Rezervisi());
        }
        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }
        DateTime _datumOD = DateTime.Now;
        public DateTime DatumOD
        {
            get { return _datumOD; }
            set { SetProperty(ref _datumOD, value); }
           
        }
        DateTime _datumDO = DateTime.Now;
        public DateTime DatumDO
        {
            get { return _datumDO; }
            set { SetProperty(ref _datumDO, value); }

        }
        public float _ukupnaCijena = 0;
        public float UkupnaCijena
        {
            get { return _ukupnaCijena; }
            set { SetProperty(ref _ukupnaCijena, value); }
        }

        public async Task Init()
        {
            var korisnik= await _korisnikService.GetById<Data.Model.Korisnik>(APIService.KorisnikId);
            Ime = korisnik.Ime;
            Prezime = korisnik.Prezime;

        }
        public async Task Rezervisi()
        {
            try
            {
                if(DatumOD.Date>DatumDO.Date)
                {
                    await Application.Current.MainPage.DisplayAlert("Neispravan unos datuma", "Početni datum rezervacije ne može biti nakon datuma završetka", "OK");
                    return;
                }
                if(DatumOD.Date<DateTime.Now)
                {
                    await Application.Current.MainPage.DisplayAlert("Neispravan unos datuma", "Početni datum rezervacije ne može prethoditi današnjem datumu. ", "OK");
                    return;
                }
                if(DatumOD.Date==DatumDO.Date)
                {
                    await Application.Current.MainPage.DisplayAlert("Neispravan unos datuma", "Rezervacija je ograničena na minimalno jedan dan.", "OK");
                    return;

                }
                var rezervisan = new RezervacijaSearchRequest { FotografId = _fotograf.FotografId };
                var listaRezervacija = await _rezervacijaService.Get < List<Data.Model.Rezervacija>>(rezervisan);
                foreach (var item in listaRezervacija)
                {
                    if(item.DatumDo.Value.Date>DatumOD.Date)
                    {
                        await Application.Current.MainPage.DisplayAlert("Greška", "Fotograf je zauzet u datom periodu", "OK");
                        return;
                    }
                }
                var request = new RezervacijaUpsert
                {
                    KorisnikId = APIService.KorisnikId,
                    DatumDo = DatumDO.Date,
                    DatumOd = DatumOD.Date,
                    FotografId = _fotograf.FotografId
                };
                await _rezervacijaService.Insert<Data.Model.Rezervacija>(request); 
                var ukupnoDana = (request.DatumDo.Value.Date - request.DatumOd.Value.Date).TotalDays;
                var ukupnaCijena = _fotograf.DnevnaCijena * ukupnoDana;

                var cijenaZaPlatiti = string.Format("Iznos koji morate uplatiti fotografu da bi rezervacija bila validna je {0} KM", ukupnaCijena);
                await Application.Current.MainPage.DisplayAlert("Obavještanje", cijenaZaPlatiti, "OK");
                await Application.Current.MainPage.DisplayAlert("Poruka", "Uplatu možete izvršiti na odjeljku 'Moje rezervacije'", "OK");


            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Ne možete rezervisati fotografa", "OK");

            }
        }
    }
}
