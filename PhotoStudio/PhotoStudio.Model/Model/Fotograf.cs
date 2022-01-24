using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Model
{
   public class Fotograf
    {
       
        public int FotografId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }
        public double? DnevnaCijena { get; set; }
        public string Opis { get; set; }
        public bool? Status { get; set; }
        public int? TipFotografaId { get; set; }

        public string  TipFotografa { get; set; }
       // public virtual ICollection<Komentar> Komentars { get; set; }
        //public virtual ICollection<Rejting> Rejtings { get; set; }
        //public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
    }
}
