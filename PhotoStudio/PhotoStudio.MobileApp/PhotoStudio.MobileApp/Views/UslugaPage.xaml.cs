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
    public partial class UslugaPage : ContentPage
    {
        private UslugaViewModel model = null;

        public UslugaPage()
        {
            InitializeComponent();
            BindingContext = model = new UslugaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }
    }
}