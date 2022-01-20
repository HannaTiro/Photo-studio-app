using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Model
{
   public  class Grad
    {
    

        public int GradId { get; set; }
        public string NazivGrada { get; set; }
        public string PostanskiBroj { get; set; }

        public virtual ICollection<Korisnik> Korisniks { get; set; }
        public virtual ICollection<Studio> Studios { get; set; }
    }
}
