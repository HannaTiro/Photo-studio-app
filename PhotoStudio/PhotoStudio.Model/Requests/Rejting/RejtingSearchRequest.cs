using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.Rejting
{
   public  class RejtingSearchRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int? Ocjena { get; set; }
        
        public int? KorisnikId { get; set; }
        public int? FotografId { get; set; }
        

     
    }
}
