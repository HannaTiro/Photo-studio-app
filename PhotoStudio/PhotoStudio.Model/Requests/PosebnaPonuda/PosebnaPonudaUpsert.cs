using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoStudio.Data.Requests.PosebnaPonuda
{
  public  class PosebnaPonudaUpsert
    {

        [Required(AllowEmptyStrings = false)]
        public string NazivPonude { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Opis { get; set; }
        [Required]
        public int? StudioId { get; set; }
    }
}
