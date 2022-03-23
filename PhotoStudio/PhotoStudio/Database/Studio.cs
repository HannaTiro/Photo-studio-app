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
            PosebnaPonuda = new HashSet<PosebnaPonuda>();
            Usluga = new HashSet<Usluga>();
            Oprema = new HashSet<Oprema>();

        }
        public int StudioId { get; set; }
        public string NazivStudija { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Opis { get; set; }
        public int? GradId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual  ICollection<Novost> Novost { get; set; }
        public virtual ICollection<PosebnaPonuda> PosebnaPonuda { get; set; }
        public virtual ICollection<Usluga> Usluga { get; set; }
        public virtual ICollection<Oprema> Oprema { get; set; }




    }
}
