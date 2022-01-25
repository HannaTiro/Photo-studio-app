using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoStudio.Data.Requests.Korisnik
{
    public class KorisnikUpsert
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        [Required]
        public int TipKorisnikaId { get; set; }
        [Required]
        public int GradId { get; set; }


    }
}
