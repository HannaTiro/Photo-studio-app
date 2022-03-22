using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Database
{
    public class Usluga
    {
        public int UslugaId { get; set; }
        public string Naziv { get; set; }
        public double  Cijena { get; set; }
        public virtual Studio Studio { get; set; }
        public int? StudioId { get; set; }
    }
}
