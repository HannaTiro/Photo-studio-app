using PhotoStudio.Data.Requests.Fotograf;
using PhotoStudio.Data.Requests.Korisnik;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.Rejting
{
   public  class RejtingRequest
    {
        public int RejtingId { get; set; }
        public int Ocjena { get; set; }
        public int? KorisnikId { get; set; }
        public int? FotografId { get; set; }
        //public DateTime? DatumOcjene { get; set; }

      public  FotografRequest Fotograf { get; set; }
      public KorisnikRequest Korisnik { get; set; }
    }
}
