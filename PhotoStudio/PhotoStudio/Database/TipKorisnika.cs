using System;
using System.Collections.Generic;

#nullable disable

namespace PhotoStudio.Database
{
    public partial class TipKorisnika
    {
        public TipKorisnika()
        {
            Korisniks = new HashSet<Korisnik>();
        }

        public int TipKorisnikaId { get; set; }
        public string Tip { get; set; }

        public virtual ICollection<Korisnik> Korisniks { get; set; }
    }
}
