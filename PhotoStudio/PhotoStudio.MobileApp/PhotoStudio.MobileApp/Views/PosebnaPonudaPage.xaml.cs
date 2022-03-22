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
    public partial class PosebnaPonudaPage : ContentPage
    {
        private PosebnaPonudaViewModel model = null;

        public PosebnaPonudaPage()
        {
            InitializeComponent();
            BindingContext = model = new PosebnaPonudaViewModel();

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }
    }
}