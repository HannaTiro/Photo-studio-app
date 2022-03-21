using System;
using System.Collections.Generic;

#nullable disable

namespace PhotoStudio.Database
{
    public partial class Studio
    {
        public Studio()
        {
            Novost = new HashSet<Novost>();
        }
        public int StudioId { get; set; }
        public string NazivStudija { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Opis { get; set; }
        public int? GradId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual  ICollection<Novost> Novost { get; set; }
    }
}
