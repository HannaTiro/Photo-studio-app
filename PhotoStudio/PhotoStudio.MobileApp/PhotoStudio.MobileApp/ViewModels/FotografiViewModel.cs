using PhotoStudio.Data.Model;
using PhotoStudio.Data.Requests.Fotograf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PhotoStudio.MobileApp.ViewModels
{
public class FotografiViewModel:BaseViewModel
    {
        private readonly APIService _fotografService = new APIService("Fotograf");
        private readonly APIService _fotografTipService = new APIService("TipFotografa");
       

        public ObservableCollection<Fotograf> ListaFotografa { get; set; } = new ObservableCollection<Fotograf>();
        public ObservableCollection<TipFotografa> ListaTipovaFotografa { get; set; } = new ObservableCollection<TipFotografa>();

        public ICommand InitCommand { get; set; }
        TipFotografa _tipF = null;
        public TipFotografa SelectedTipFotografa
        {
            get { return _tipF; }
            set 
            { 
                SetProperty(ref _tipF, value);
                if(value!=null)
                {
                    InitCommand.Execute(null);

                }

            }
        }


        public FotografiViewModel()
        {
            InitCommand = new Command(async () => await Init());
           
        }
        public async Task Init()
        {
            
            if (ListaTipovaFotografa.Count==0)
            {
                var listTipoviFotografa = await _fotografTipService.Get<List<TipFotografa>>(null);
                foreach (var tip in listTipoviFotografa)
                {
                    ListaTipovaFotografa.Add(tip);
                }
            }
            if(SelectedTipFotografa!=null)
            {
                FotografSearchRequest search = new FotografSearchRequest();
                search.TipFotografa = SelectedTipFotografa.Naziv;
                var listaFotografa = await _fotografService.Get<List<Fotograf>>(search);
                ListaFotografa.Clear();
                foreach (var fot in listaFotografa)
                {
                    ListaFotografa.Add(fot);
                }
                if (listaFotografa.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Trenutno nema dostupnih fotografa", "OK");

                }
            }
          
          
        }



    }
}
