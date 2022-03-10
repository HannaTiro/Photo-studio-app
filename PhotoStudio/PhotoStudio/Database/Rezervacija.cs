using System;
using System.Collections.Generic;

#nullable disable

namespace PhotoStudio.Database
{ 
    public partial class Rezervacija
    {
        public int RezervacijaId { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public int? KorisnikId { get; set; }
        public int? FotografId { get; set; }
        public bool IsKomentarisano { get; set; } = false;
        public bool IsOcijenjeno { get; set; } = false;
        public bool IsPlaceno { get; set; } = false;

        public virtual Fotograf Fotograf{ get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
