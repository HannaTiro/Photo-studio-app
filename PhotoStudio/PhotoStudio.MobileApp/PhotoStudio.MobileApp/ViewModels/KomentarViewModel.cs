using PhotoStudio.Data.Requests.Komentar;
using PhotoStudio.Data.Requests.Rezervacija;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PhotoStudio.MobileApp.ViewModels
{
   public  class KomentarViewModel:BaseViewModel
    {
        private readonly APIService _korisnikService = new APIService("Korisnik");
        private readonly APIService _komentarService = new APIService("Komentar");
        private readonly APIService _rezervacijaService = new APIService("Rezervacija");
        private readonly APIService _fotografService = new APIService("Fotograf");
        public Data.Model.Korisnik _korisnik { get; set; }
        public Data.Model.Fotograf _fotograf { get; set; }


        public ICommand InitCommand { get; set; }
        public ICommand KomentarisiCommand { get; set; }
        public KomentarViewModel()
        {
            InitCommand = new Command(async () => await Init());
            KomentarisiCommand = new Command(async () => await Komentarisi());

        }
       

        private string _komentar = string.Empty;
        public string KomentarOpis { get { return _komentar; } set { SetProperty(ref _komentar, value); } }

        private DateTime _datum = DateTime.Now.Date;
        public DateTime DatumKomentara { get { return _datum; } set { SetProperty(ref _datum, value); } }

        public async Task Init()
        {
            var korisnik = await _korisnikService.GetById<Data.Model.Korisnik>(APIService.KorisnikId);
            _korisnik = korisnik;
            
     
        }
        public async Task Komentarisi()
        {
            if(string.IsNullOrEmpty(KomentarOpis))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti komentar", "OK");
                return;
            }
            try
            {
                var korisnik = await _korisnikService.GetById<Data.Model.Korisnik>(APIService.KorisnikId);
                _korisnik = korisnik;

                var fotograf = await _fotografService.GetById<Data.Model.Fotograf>(_fotograf.FotografId);
                var request = new KomentarUpsert
                {
                    Datum=DatumKomentara,
                    FotografId=_fotograf.FotografId,
                    KorisnikId=APIService.KorisnikId,
                    Opis=KomentarOpis
                };
                var listaKomentara = await _komentarService.Get<List<Data.Model.Komentar>>(new KomentarSearchRequest
                {
                    FotografId=request.FotografId,
                    KorisnikId=request.KorisnikId
                });
                foreach (var item in listaKomentara)
                {
                    if(item.Datum.Value==DatumKomentara.Date)
                    {
                        await Application.Current.MainPage.DisplayAlert("Poruka", "Već ste ostavili komentar na ovu rezervaciju za datog fotografa", "OK");
                        return;
                    }

                }
                request.Datum = DateTime.Now.Date;
                await _komentarService.Insert<Data.Model.Komentar>(request);
                await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste ostavili komentar na ovu rezervaciju za datog fotografa", "OK");

                //update-aj rezervaciju, ostavi joj komentar
                var listaRezervacija = await _rezervacijaService.Get<List<Data.Model.Rezervacija>>(new RezervacijaSearchRequest
                {
                   KorisnikId=_korisnik.KorisnikId
                });

                foreach (var rez in listaRezervacija)
                {
                    if (rez.FotografId == _fotograf.FotografId && rez.KorisnikId == _korisnik.KorisnikId)
                    {
                        if (rez.isKomentarisano == false) //provjera da li postoji komentar vec, jer je jednu rezervaciju dozvoljeno kom samo jednom 
                        {
                            var nova = new RezervacijaUpsert
                            {
                                DatumDo = rez.DatumDo,
                                DatumOd = rez.DatumOd,
                                FotografId = rez.Fotograf.FotografId,
                                KorisnikId = rez.Korisnik.KorisnikId,
                                isKomentarisano = true
                            };
                            await _rezervacijaService.Update<Data.Model.Rezervacija>(rez.RezervacijaId, nova); 
                            return;
                       }
                            
                        
                    }
                }

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Neuspješno ostavljen komentar ","OK");

            }
        }


    }
}
