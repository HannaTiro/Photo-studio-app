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
    public partial class RegistracijaPage : ContentPage
    {
        private readonly RegistracijaViewModel model;
        public RegistracijaPage()
        {
            InitializeComponent();
            this.BindingContext = model = new RegistracijaViewModel();
        }
    
        private async void Button_Clicked_Canceled(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginPage());
        }
    }
}