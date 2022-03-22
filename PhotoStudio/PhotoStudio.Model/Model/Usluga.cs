using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Model
{
   public  class Usluga
    {
        public int UslugaId { get; set; }
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public  Studio Studio { get; set; }
        public int? StudioId { get; set; }
    }
}
