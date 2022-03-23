using PhotoStudio.Data.Requests.Studio;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.Oprema
{
    public class OpremaRequest
    {
        public int OpremaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int Kolicina { get; set; }
        public StudioRequest Studio { get; set; }


    }
}
