using PhotoStudio.MobileApp.Models;
using PhotoStudio.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhotoStudio.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class PocetniPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> listaMeniPage = new Dictionary<int, NavigationPage>();
        public PocetniPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!listaMeniPage.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Fotografi:
                        listaMeniPage.Add(id, new NavigationPage(new FotografiPage()));
                        break;
              
                }
            }
            var newPage = listaMeniPage[id];
            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);
                newPage.Title = Title;
                IsPresented = false;
            }
        }
    }
}