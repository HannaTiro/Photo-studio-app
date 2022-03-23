using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Model
{
  public   class Oprema
    {
        public int OpremaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int Kolicina { get; set; }
        public  Studio Studio { get; set; }
        public int? StudioId { get; set; }
    }
}
