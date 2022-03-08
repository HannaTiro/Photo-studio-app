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
    public partial class KomentarPage : ContentPage
    {
        KomentarViewModel model = null;
        public KomentarPage( Data.Model.Fotograf f)
        {
            InitializeComponent();
            BindingContext = model = new KomentarViewModel { _fotograf=f};
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}