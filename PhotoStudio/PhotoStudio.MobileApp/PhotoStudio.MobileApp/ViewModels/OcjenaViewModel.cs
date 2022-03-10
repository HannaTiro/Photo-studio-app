using PhotoStudio.Data.Requests.Rejting;
using PhotoStudio.Data.Requests.Rezervacija;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PhotoStudio.MobileApp.ViewModels
{
   public  class OcjenaViewModel:BaseViewModel
    {
        private readonly APIService _korisnikService = new APIService("Korisnik");
        private readonly APIService _fotografService = new APIService("Fotograf");
        private readonly APIService _rejtingService = new APIService("Rejting");
        private readonly APIService _rezervacijaService = new APIService("Rezervacija");

        public ICommand InitCommand { get; set; }
        public ICommand OcijeniCommand { get; set; }
        public Data.Model.Fotograf _fotograf { get; set; }
        public Data.Model.Korisnik _korisnik { get; set; }


        public OcjenaViewModel()
        {
            InitCommand = new Command(async () => await Init());
            OcijeniCommand = new Command(async () => await Ocijeni());
        }
       

        private string _imeF = string.Empty;
        public string FotografIme{ get { return _imeF; } set { SetProperty(ref _imeF, value); } }

        private string _prezimeF = string.Empty;
        public string FotografPrezime { get { return _prezimeF; } set { SetProperty(ref _prezimeF, value); } }
        public async Task Init()
        {
            var korisnik = await _korisnikService.GetById<Data.Model.Korisnik>(APIService.KorisnikId);
            _korisnik = korisnik;

            var fotograf = await _fotografService.GetById<Data.Model.Fotograf>(_fotograf.FotografId);
            _fotograf = fotograf;
            FotografIme = _fotograf.Ime;
            FotografPrezime = _fotograf.Prezime;


        }

        public int _ocjena = 0;
        public int Ocjena
        {
            get { return _ocjena; }
            set { SetProperty(ref _ocjena, value); }
        }
        DateTime _datum = DateTime.Now;
        public DateTime DatumOcjene
        {
            get { return _datum; }
            set { SetProperty(ref _datum, value); }
        }
        public async Task Ocijeni()
        {
            if(Ocjena<=0 || Ocjena>5)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Ocjene su od 1 do 5", "OK");
                return;
            }
            try
            {
                var korisnik = await _korisnikService.GetById<Data.Model.Korisnik>(APIService.KorisnikId);
                _korisnik = korisnik;
                var fotograf = await _korisnikService.GetById<Data.Model.Fotograf>(_fotograf.FotografId);
                var request = new RejtingUpsert
                {
                    KorisnikId = APIService.KorisnikId,
                    DatumOcjene = DatumOcjene,
                    FotografId = _fotograf.FotografId,
                    Ocjena = Ocjena
                };
                var ocjene = await _rejtingService.Get<List<Data.Model.Rejting>>(new RejtingSearchRequest
                {
                    FotografId=_fotograf.FotografId,
                    KorisnikId=_korisnik.KorisnikId
                });
                foreach (var item in ocjene)
                {
                    if(DatumOcjene.Date==item.DatumOcjene.Value)
                    {
                        await Application.Current.MainPage.DisplayAlert("Poruka", "Već ste ostavili ocjenu na ovu rezervaciju za datog fotografa", "OK");
                        return;
                    }
                }
                request.DatumOcjene = DateTime.Now.Date;
                await _rejtingService.Insert<Data.Model.Rejting>(request);
                await Application.Current.MainPage.DisplayAlert("Poruka", "Uspješno ste ocjenili ovu rezervaciju za datog fotografa", "OK");
               
                //update-aj rezervaciju, ostavi joj ocjenu
                var listaRezervacija = await _rezervacijaService.Get<List<Data.Model.Rezervacija>>(new RezervacijaSearchRequest
                {
                    KorisnikId = _korisnik.KorisnikId
                });

                foreach (var rez in listaRezervacija)
                {
                    if (rez.FotografId == _fotograf.FotografId && rez.KorisnikId == _korisnik.KorisnikId)
                    {
                        if (rez.IsOcijenjeno == false) //provjera da li postoji komentar vec, jer je jednu rezervaciju dozvoljeno kom samo jednom 
                        {
                            var nova = new RezervacijaUpsert
                            {
                                DatumDo = rez.DatumDo,
                                DatumOd = rez.DatumOd,
                                FotografId = rez.Fotograf.FotografId,
                                KorisnikId = rez.Korisnik.KorisnikId,
                                IsKomentarisano = rez.IsKomentarisano,
                                IsOcijenjeno = true,
                                IsPlaceno=rez.IsPlaceno
                                
                            };
                            await _rezervacijaService.Update<Data.Model.Rezervacija>(rez.RezervacijaId, nova);
                            return;
                        }


                    }
                }
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Neuspješno data ocjena", "OK");
                return;
            }
        }

    }
}
