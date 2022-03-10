using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Model
{
    public class Rezervacija
    {
        public int RezervacijaId { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public int? KorisnikId { get; set; }
        public int? FotografId { get; set; }
        public bool? isKomentarisano { get; set; } = false; //pomocna
        public bool? isOcijenjeno { get; set; } = false; //pomocna
        public bool? isPlaceno { get; set; } = false; //pomocna

        public Fotograf Fotograf { get; set; }
        public  Korisnik Korisnik { get; set; }
    }
}
