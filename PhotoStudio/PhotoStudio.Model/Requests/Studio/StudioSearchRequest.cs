using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.Studio
{
    public class StudioSearchRequest
    {
        
        public string NazivStudija { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public int? GradId { get; set; }

    }
}
