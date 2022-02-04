using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoStudio.Data.Requests.Korisnik
{
    public class KorisnikUpsert
    {
        [Required (AllowEmptyStrings =false)]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Telefon { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]
       [ MinLength(4)]
        public string Username { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Password { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string PasswordConfirm { get; set; }
        [Required]
        public int TipKorisnikaId { get; set; }
        [Required]
        public int GradId { get; set; }


    }
}
