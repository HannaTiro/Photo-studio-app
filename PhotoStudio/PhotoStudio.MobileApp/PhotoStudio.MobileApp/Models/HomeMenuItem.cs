using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.MobileApp.Models
{

    public enum MenuItemType
    {
        Browse,
        Kontakt,
        Fotografi,
        Rezervacije,
        Komentari,
        Ocjene,
        LogOut,
        PostavkeProfila,
        Novosti,
        PosebnaPonuda
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
