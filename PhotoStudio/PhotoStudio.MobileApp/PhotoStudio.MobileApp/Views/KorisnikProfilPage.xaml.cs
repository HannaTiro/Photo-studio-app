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
    public partial class KorisnikProfilPage : ContentPage
    {
        KorisnikProfilViewModel model = null;
        public KorisnikProfilPage()
        {
            InitializeComponent();
            BindingContext = model = new KorisnikProfilViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Uredi(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UrediKorisnikProfilPage());
        }
    }
}