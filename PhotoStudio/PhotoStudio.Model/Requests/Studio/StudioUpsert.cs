using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoStudio.Data.Requests.Studio
{
   public  class StudioUpsert
    {
        [Required(AllowEmptyStrings = false)]
        public string NazivStudija { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Adresa { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Telefon { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Opis { get; set; }
        [Required]
        public int? GradId { get; set; }

        
    }
}
