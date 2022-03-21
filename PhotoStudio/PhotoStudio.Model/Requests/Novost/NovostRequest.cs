using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.Novost
{
   public  class NovostRequest
    {
        public int NovostId { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime DatumObjave { get; set; }

      
    }
}
