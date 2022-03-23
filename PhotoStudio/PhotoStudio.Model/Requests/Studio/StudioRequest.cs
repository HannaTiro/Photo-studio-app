using PhotoStudio.Data.Requests.Grad;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.Studio
{
    public class StudioRequest
    {
        
        public string NazivStudija { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Opis { get; set; }
        public int StudioId { get; set; }

    }
}
