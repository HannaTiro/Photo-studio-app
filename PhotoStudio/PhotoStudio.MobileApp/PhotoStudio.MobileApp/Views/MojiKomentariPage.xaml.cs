using PhotoStudio.MobileApp.ViewModels;
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
    public partial class MojiKomentariPage : ContentPage
    {
        MojiKomentariViewModel model = null;
        public MojiKomentariPage()
        {
            InitializeComponent();
            BindingContext = model = new MojiKomentariViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var rez = e.Item as Data.Model.Rezervacija;

            await Navigation.PushAsync(new KomentarPage(rez.Fotograf));
        }
    }
}