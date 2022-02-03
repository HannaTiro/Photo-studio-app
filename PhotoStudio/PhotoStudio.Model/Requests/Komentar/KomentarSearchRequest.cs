using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.Komentar
{
   public  class KomentarSearchRequest
    {
     
       // public DateTime? Datum { get; set; }
        public int? KorisnikId { get; set; }
        public string ImeKorisnika { get; set; }
        public string PrezimeKorisnika { get; set; }
        public int? FotografId { get; set; }

    }
}
