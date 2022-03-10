using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using PhotoStudio.Data.Requests.Recommend;

namespace PhotoStudio.MobileApp.ViewModels
{
    public class FotografDetaljiViewModel: BaseViewModel
    {
        private readonly APIService _fotografService = new APIService("Fotograf");
        private readonly APIService _fotografRejting = new APIService("Rejting");
        private readonly APIService _preporukaService = new APIService("Preporuka");


        public ICommand InitCommand { get; set; }

        public FotografDetaljiViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }
        private string _ocjena = string.Empty;
        public string ProsjecnaOcjena
        {
            get { return _ocjena; }
            set { SetProperty(ref _ocjena, value); }
        }
        public ObservableCollection<Data.Model.Fotograf> PreporukaFotografiLista { get; set; } = new ObservableCollection<Data.Model.Fotograf>();
        public Data.Model.Fotograf _fotograf { get; set; } = null;
        public async Task Init()
        {
            var RejtingLista = await _fotografRejting.Get<List<Data.Model.Rejting>>(null);
            var request = new RecommendSearchRequest { FotografId = _fotograf.FotografId };
            List<Data.Model.Fotograf> preporuke = await _preporukaService.Get<List<Data.Model.Fotograf>>(request);
            PreporukaFotografiLista.Clear();

            foreach (var p in preporuke)
            {
                PreporukaFotografiLista.Add(p);
            }

            float prosjecna = 0;
            int brojacOcjena = 0;
            foreach (var item in RejtingLista)
            {
                if(_fotograf.FotografId==item.FotografId)
                {
                    prosjecna += item.Ocjena;
                    brojacOcjena++;
                }
            }
            if(prosjecna==0)
            {
                ProsjecnaOcjena = "Fotograf još nije ocjenjen";
                return;
            }
            ProsjecnaOcjena = (prosjecna / brojacOcjena).ToString();

        }
    }
}
