using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoStudio.Data.Requests.Rejting
{
   public  class RejtingUpsert
    {
        [Required]
        public int Ocjena { get; set; }
        [Required]
        public int KorisnikId { get; set; }
        [Required]
        public int FotografId { get; set; }
        public DateTime? DatumOcjene { get; set; }


    }
}
