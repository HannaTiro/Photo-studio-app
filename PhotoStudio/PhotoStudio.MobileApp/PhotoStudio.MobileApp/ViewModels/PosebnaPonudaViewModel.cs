using PhotoStudio.Data.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;


using System.Threading.Tasks;

using Xamarin.Forms;
using PhotoStudio.Data.Requests.PosebnaPonuda;

namespace PhotoStudio.MobileApp.ViewModels
{
    public class PosebnaPonudaViewModel:BaseViewModel
    {
        private readonly APIService _ponudaService = new APIService("PosebnaPonuda");
        private readonly APIService _studioService = new APIService("Studio");

        public ObservableCollection<PosebnaPonuda> ListaPonuda { get; set; } = new ObservableCollection<PosebnaPonuda>();
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

        public PosebnaPonudaViewModel()
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
                PosebnaPonudaSearchRequest search = new PosebnaPonudaSearchRequest();
                search.Studio = SelectedStudio.NazivStudija;

                var lista = await _ponudaService.Get<List<PosebnaPonuda>>(search);
                ListaPonuda.Clear();
                foreach (var n in lista)
                {
                    ListaPonuda.Add(n);
                }
                if (lista.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Poruka", "Trenutno nema objavljenih novosti za studio", "OK");

                }
            }


        }
    }
}
