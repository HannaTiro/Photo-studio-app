using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoStudio.Data.Requests.Novost
{
    public class NovostUpsert
    {
     
        [Required(AllowEmptyStrings = false)]
        public string Naslov { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Sadrzaj { get; set; }

        [Required]
        public DateTime DatumObjave { get; set; }

        [Required]
        public int? StudioId { get; set; }
    }
}
