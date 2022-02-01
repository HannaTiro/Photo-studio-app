using PhotoStudio.Data.Requests.TipFotografa;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.Fotograf
{
    public class FotografRequest
    {
        public int FotografId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }
        public double? DnevnaCijena { get; set; }
        public string Opis { get; set; }
        public bool? Status { get; set; }
        public int? TipFotografaId { get; set; }
      // public string TipFotografa { get; set; }

        public  TipFotografaRequest TipFotografa { get; set; }
    }
}
