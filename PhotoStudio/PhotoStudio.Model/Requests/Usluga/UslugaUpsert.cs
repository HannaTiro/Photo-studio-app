using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoStudio.Data.Requests.Usluga
{
    public class UslugaUpsert
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        [Required]
        public double Cijena { get; set; }
        [Required]
        public int? StudioId { get; set; }
    }
}
