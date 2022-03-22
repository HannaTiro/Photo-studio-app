using PhotoStudio.Data.Model;
using PhotoStudio.Data.Requests.Novost;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PhotoStudio.MobileApp.ViewModels
{
   public  class NovostiViewModel:BaseViewModel
    {
        private readonly APIService _novostService = new APIService("Novost");
        private readonly APIService _studioService = new APIService("Studio");

        public ObservableCollection<Novost> ListaNovosti { get; set; } = new ObservableCollection<Novost>();
        public ObservableCollection<Studio> ListaStudija{ get; set; } = new ObservableCollection<Studio>();

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

    

        public NovostiViewModel()
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
                NovostSearchRequest search = new NovostSearchRequest();
                search.Studio = SelectedStudio.NazivStudija;
               
                var lista = await _novostService.Get<List<Novost>>(search);
                ListaNovosti.Clear();
                foreach (var n in lista)
                {
                    ListaNovosti.Add(n);
                }
                if (lista.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Poruka", "Trenutno nema objavljenih novosti za studio", "OK");

                }
            }


        }



    }
}
