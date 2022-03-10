using PhotoStudio.MobileApp.ViewModels;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhotoStudio.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MojeRezervacijePage : ContentPage
    {
        private MojeRezervacijeViewModel model=null;
        public MojeRezervacijePage()
        {
            InitializeComponent();
            BindingContext = model = new MojeRezervacijeViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var rezervacija = e.Item as Data.Model.Rezervacija;
            if (rezervacija.IsPlaceno)
            {
                await DisplayAlert("Greška", "Rezervacija je već plaćena", "OK");
                return;
            }

           await Navigation.PushAsync(new RezervacijaPlatiPage(rezervacija));
        }
      
     
    }
}