using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.TipKorisnika
{
    public class TipKorisnikaRequest
    {
        public int? TipKorisnikaId { get; set; }
        public string Tip { get; set; }
    }
}
