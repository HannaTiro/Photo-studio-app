using System;
using System.Collections.Generic;

#nullable disable

namespace PhotoStudio.Database
{
    public partial class Komentar
    {
        public int KomentarId { get; set; }
        public string Opis { get; set; }
        public DateTime? Datum { get; set; }
        public int? KorisnikId { get; set; }
        public int? FotografId { get; set; }

        public virtual Fotograf Fotograf { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
