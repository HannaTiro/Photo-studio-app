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
    public partial class UrediKorisnikProfilPage : ContentPage
    {
        UrediKorisnikProfilViewModel model = null;
        public UrediKorisnikProfilPage()
        {
            InitializeComponent();
            BindingContext = model = new UrediKorisnikProfilViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}