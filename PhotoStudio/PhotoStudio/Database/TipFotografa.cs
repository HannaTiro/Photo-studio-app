using System;
using System.Collections.Generic;

#nullable disable

namespace PhotoStudio.Database
{
    public partial class TipFotografa
    {
        public TipFotografa()
        {
            Fotografs = new HashSet<Fotograf>();
        }

        public int TipFotografaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Fotograf> Fotografs { get; set; }
    }
}
