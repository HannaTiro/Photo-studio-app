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
    public partial class NovostiPage : ContentPage
    {
        private NovostiViewModel model = null;

        public NovostiPage()
        {
            InitializeComponent();
            BindingContext = model = new NovostiViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }
     
    }
}