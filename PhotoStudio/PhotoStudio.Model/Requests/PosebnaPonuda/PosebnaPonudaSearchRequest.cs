using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.PosebnaPonuda
{
   public  class PosebnaPonudaSearchRequest
    {
      
        public string NazivPonude { get; set; }
        public string Opis { get; set; }
        public string Studio { get; set; }
        public int? StudioId { get; set; }

    }
}
