using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoStudio.Data.Requests.Rezervacija
{
    public class RezervacijaUpsert
    {
        [Required]
        public int FotografId { get; set; }
        [Required]
        public int KorisnikId { get; set; }
        [Required]
        public DateTime? DatumOd { get; set; }
        [Required]
        public DateTime? DatumDo { get; set; }
     
    }
}
