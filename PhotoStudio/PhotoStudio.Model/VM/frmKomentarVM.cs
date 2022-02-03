using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.VM
{
   public  class frmKomentarVM
    {
        public int KomentarId { get; set; }
        public int KorisnikId { get; set; }
        public int FotografId { get; set; }
        public string ImeKorisnika { get; set; }
        public string PrezimeKorisnika { get; set; }
        public string Opis { get; set; }
    }
}
