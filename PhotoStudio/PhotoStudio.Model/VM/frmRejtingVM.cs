using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.VM
{
   public class frmRejtingVM
    {
        public int RejtingId { get; set; }
        public int? Ocjena { get; set; }
        public string ImeFotografa { get; set; }
        public string PrezimeFotografa { get; set; }
        public int FotografId { get; set; }
        public int KorisnikId { get; set; }
        public string ImeKorisnika { get; set; }
        public string PrezimeKorisnika { get; set; }
    }
}
