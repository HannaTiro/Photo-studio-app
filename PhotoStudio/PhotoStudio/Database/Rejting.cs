using System;
using System.Collections.Generic;

#nullable disable

namespace PhotoStudio.Database
{
    public partial class Rejting
    {
        public int RejtingId { get; set; }
        public int? Ocjena { get; set; }
        public int? Korisnik { get; set; }
        public int? Fotograf { get; set; }
        public DateTime? DatumOcjene { get; set; }

        public virtual Fotograf FotografNavigation { get; set; }
        public virtual Korisnik KorisnikNavigation { get; set; }
    }
}
