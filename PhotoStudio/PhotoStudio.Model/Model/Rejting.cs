using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Model
{
    public class Rejting
    {
        public int RejtingId { get; set; }
        public int? Ocjena { get; set; }
        public int? KorisnikId { get; set; }
        public int? FotografId { get; set; }
        public DateTime? DatumOcjene { get; set; }

       //public Korisnik Korisniks { get; set; }

        public  Fotograf Fotograf{ get; set; }
         public  Korisnik Korisnik{ get; set; }
    }
}
