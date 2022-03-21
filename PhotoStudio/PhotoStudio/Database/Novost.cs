using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Database
{
    public class Novost
    {
        public int NovostId { get; set; }
        public string Naslov { get; set; }
        public string  Sadrzaj { get; set; }
        public DateTime DatumObjave { get; set; }
        public virtual Studio Studio { get; set; }
        public int? StudioId { get; set; }
    }
}
