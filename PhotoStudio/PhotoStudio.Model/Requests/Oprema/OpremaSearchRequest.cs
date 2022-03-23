using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.Oprema
{
    public class OpremaSearchRequest
    {
       
        public string Naziv { get; set; }
        public string Opis { get; set; }
        
        public  string Studio { get; set; }
        public int? StudioId { get; set; }

    }
}
