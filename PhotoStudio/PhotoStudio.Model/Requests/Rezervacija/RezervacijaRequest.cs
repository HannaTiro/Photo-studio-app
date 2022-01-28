using PhotoStudio.Data.Requests.Fotograf;
using PhotoStudio.Data.Requests.Korisnik;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.Rezervacija
{
    public class RezervacijaRequest
    {
        public int RezervacijaId { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public FotografRequest Fotograf { get; set; }
        public KorisnikRequest Korisnik { get; set; }
    }
}
