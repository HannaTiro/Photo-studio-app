using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Model
{
    public class Novost
    {
        public int NovostId { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime DatumObjave { get; set; }
        public  Studio Studio { get; set; }
        public int? StudioId { get; set; }
    }
}
