using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.Fotograf
{
   public class FotografSearchRequest
    {
       
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string TipFotografa { get; set; }

    }
}
