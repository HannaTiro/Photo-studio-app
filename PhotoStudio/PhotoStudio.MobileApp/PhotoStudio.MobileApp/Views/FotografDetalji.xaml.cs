using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoStudio.MobileApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhotoStudio.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FotografDetalji : ContentPage
    {
        FotografDetaljiViewModel model = null;
        public FotografDetalji(Data.Model.Fotograf fotograf)
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, true);
            BindingContext = model = new FotografDetaljiViewModel
            {
                _fotograf = fotograf
            };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        //BOOKING DUGME POZIV 
    }
}
