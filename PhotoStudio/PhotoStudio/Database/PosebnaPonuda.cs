using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Database
{
    public class PosebnaPonuda
    {
        public int PosebnaPonudaId { get; set; }
        public string NazivPonude { get; set; }
        public  string Opis { get; set; }
        public virtual Studio Studio { get; set; }
        public int? StudioId { get; set; }
    }
}
