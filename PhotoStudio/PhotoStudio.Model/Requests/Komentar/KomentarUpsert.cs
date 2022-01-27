using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoStudio.Data.Requests.Komentar
{
   public  class KomentarUpsert
    {
        [Required]
        public int? KorisnikId { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Opis { get; set; }


        [Required]
        public DateTime? Datum { get; set; }

        [Required]
        public int? FotografId { get; set; }
       
       
    }
}
