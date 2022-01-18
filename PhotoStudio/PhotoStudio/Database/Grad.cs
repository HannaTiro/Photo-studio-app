using System;
using System.Collections.Generic;

#nullable disable

namespace PhotoStudio.Database
{
    public partial class Grad
    {
        public Grad()
        {
            Korisniks = new HashSet<Korisnik>();
            Studios = new HashSet<Studio>();
        }

        public int GradId { get; set; }
        public string NazivGrada { get; set; }
        public string PostanskiBroj { get; set; }

        public virtual ICollection<Korisnik> Korisniks { get; set; }
        public virtual ICollection<Studio> Studios { get; set; }
    }
}
