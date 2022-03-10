using System;
using System.Collections.Generic;

#nullable disable

namespace PhotoStudio.Database
{
    public partial class Rejting
    {
        public int RejtingId { get; set; }
        public int Ocjena { get; set; } //bio ?
        public int? KorisnikId { get; set; }
        public int? FotografId { get; set; }
        public DateTime? DatumOcjene { get; set; }

        public virtual Fotograf Fotograf{ get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
