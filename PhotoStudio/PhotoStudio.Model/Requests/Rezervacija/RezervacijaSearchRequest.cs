using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.Rezervacija
{
    public class RezervacijaSearchRequest
    {
        
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public int? KorisnikId { get; set; }
        public string ImeKorisnika { get; set; }
        public int? FotografId { get; set; }
        public string ImeFotografa { get; set; }



    }
}
