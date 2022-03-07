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
    public partial class FotografRezervacija : ContentPage
    {
        FotografRezervacijaViewModel model = null;

        public FotografRezervacija(Data.Model.Fotograf rezervacija)
        {
            InitializeComponent();
            BindingContext = model = new FotografRezervacijaViewModel
            {
                _fotograf = rezervacija
            };
            NavigationPage.SetHasBackButton(this, true);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }


    }
}