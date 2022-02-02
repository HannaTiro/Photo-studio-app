using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.VM
{
   public  class frmBookingVM
    {
        public int BookinId { get; set; }
   
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }



    }
}
