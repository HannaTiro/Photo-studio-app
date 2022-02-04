using PhotoStudio.Data.Requests.Fotograf;
using PhotoStudio.Data.Requests.Korisnik;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.Komentar
{
     public class KomentarRequest
    {
        public int KomentarId { get; set; }
        public string Opis { get; set; }
        public DateTime? Datum { get; set; }
      //  public int? KorisnikId { get; set; }
        //public int? FotografId { get; set; }
        public KorisnikRequest Korisnik { get; set; }
         public  FotografRequest Fotograf { get; set; }
         //public  Korisnik Korisnik { get; set; }
    }
}
