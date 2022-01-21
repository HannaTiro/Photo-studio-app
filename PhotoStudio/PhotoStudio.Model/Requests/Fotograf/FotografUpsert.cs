using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoStudio.Data.Requests.Fotograf
{
    public class FotografUpsert
    {
        [Required]
        public string Ime { get; set; }

        [Required]
        public string Prezime { get; set; }

        public byte[] Slika { get; set; }
        public double? DnevnaCijena { get; set; }
        public string Opis { get; set; }
        public bool? Status { get; set; }

        [Required]
        public int? TipFotografaId { get; set; }

       
    }
}
