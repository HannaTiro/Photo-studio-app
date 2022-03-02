using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PhotoStudio.MobileApp.ViewModels
{
public class FotografiViewModel
    {
        private readonly APIService _fotografService = new APIService("Fotograf");
        public ObservableCollection<Data.Model.Fotograf> ListaFotografa { get; set; } = new ObservableCollection<Data.Model.Fotograf>();
        public ICommand InitCommand { get; set; }
        public ICommand PretragaFotografa { get; set; }

        public FotografiViewModel()
        {
            InitCommand = new Command(async () => await Init());
            //PretragaFotografa = new Command(async () => await Load());
        }
        public async Task Init()
        {
            var listaFotografa = await _fotografService.Get<List<Data.Model.Fotograf>>(null);
            ListaFotografa.Clear();
            foreach (var fot in listaFotografa)
            {
                listaFotografa.Add(fot);
            }
            if(listaFotografa.Count==0)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Trenutno nema dostupnih fotografa", "OK");

            }
        }



    }
}
