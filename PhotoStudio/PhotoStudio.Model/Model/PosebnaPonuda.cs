using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Model
{
   public  class PosebnaPonuda
    {
        public int PosebnaPonudaId { get; set; }
        public string NazivPonude { get; set; }
        public string Opis { get; set; }
        public  Studio Studio { get; set; }
        public int? StudioId { get; set; }
    }
}
