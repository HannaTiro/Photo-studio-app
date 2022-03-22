using PhotoStudio.Data.Requests.Studio;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.Novost
{
    public class NovostSearchRequest
    {

        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public string DatumObjave { get; set; }
        public string Studio { get; set; }


    }
}
