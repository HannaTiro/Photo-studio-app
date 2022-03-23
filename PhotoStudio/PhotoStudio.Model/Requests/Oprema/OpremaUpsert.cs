using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoStudio.Data.Requests.Oprema
{
   public  class OpremaUpsert
    {
        [Required(AllowEmptyStrings = false)]

        public string Naziv { get; set; }
        [Required(AllowEmptyStrings = false)]

        public string Opis { get; set; }
        [Required]
        public int Kolicina { get; set; }
        [Required]
        public int? StudioId { get; set; }
    }
}
