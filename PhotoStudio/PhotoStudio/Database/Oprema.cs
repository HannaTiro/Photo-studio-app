using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Database
{
    public class Oprema
    {
        public int OpremaId { get; set; }
        public string Naziv { get; set; }
        public string  Opis { get; set; }
        public int Kolicina { get; set; }
        public virtual Studio Studio { get; set; }
        public int? StudioId { get; set; }
    }
}
