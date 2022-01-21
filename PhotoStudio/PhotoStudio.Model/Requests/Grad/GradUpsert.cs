using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoStudio.Data.Requests.Grad
{
    public class GradUpsert
    {
        [Required]
        public string NazivGrada { get; set; }

        [Required]
        public string PostanskiBroj { get; set; }
    }
}
