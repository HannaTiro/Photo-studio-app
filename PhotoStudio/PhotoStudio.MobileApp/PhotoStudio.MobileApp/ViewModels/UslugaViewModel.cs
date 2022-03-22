using PhotoStudio.Data.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

using System.Windows.Input;
using System.Threading.Tasks;
using PhotoStudio.Data.Requests.Usluga;

namespace PhotoStudio.MobileApp.ViewModels
{
    public class UslugaViewModel:BaseViewModel
    {
        private readonly APIService _uslugaService = new APIService("Usluga");
        private readonly APIService _studioService = new APIService("Studio");

        public ObservableCollection<Usluga> ListaUsluga { get; set; } = new ObservableCollection<Usluga>();
        public ObservableCollection<Studio> ListaStudija { get; set; } = new ObservableCollection<Studio>();

        public ICommand InitCommand { get; set; }
        Studio _studio = null;
        public Studio SelectedStudio
        {
            get { return _studio; }
            set
            {
                SetProperty(ref _studio, value);
                if (value != null)
                {
                    InitCommand.Execute(null);

                }

            }
        }
        public UslugaViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }
        public async Task Init()
        {

            if (ListaStudija.Count == 0)
            {
                var listStudios = await _studioService.Get<List<Studio>>(null);
                foreach (var s in listStudios)
                {
                    ListaStudija.Add(s);
                }
            }
            if (SelectedStudio != null)
            {
                UslugaSearchRequest search = new UslugaSearchRequest();
                search.Studio = SelectedStudio.NazivStudija;

                var lista = await _uslugaService.Get<List<Usluga>>(search);
                ListaUsluga.Clear();
                foreach (var n in lista)
                {
                    ListaUsluga.Add(n);
                }
                if (lista.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Poruka", "Trenutno nema objavljenih usluga za ovaj studio", "OK");

                }
            }


        }
    }
}
