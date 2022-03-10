using Microsoft.EntityFrameworkCore;
using PhotoStudio.Database;
using PhotoStudio.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Seeder
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<string> Salt = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Salt.Add(HashGenerator.GenerateSalt());
            }

            #region Dodavanje tipova korisnika
            modelBuilder.Entity<TipKorisnika>().HasData(
                new TipKorisnika()
                {
                    TipKorisnikaId = 1,
                    Tip = "Korisnik"
                }
                );
            #endregion
            #region Dodavanje tipova fotografa
            modelBuilder.Entity<TipFotografa>().HasData(
                new TipFotografa()
                {
                    TipFotografaId = 1,
                    Naziv = "Vjencanje"
                },
                new TipFotografa()
                {
                    TipFotografaId = 2,
                    Naziv = "Rođendan"
                }
                );
            #endregion
            #region Dodavanje gradova
            modelBuilder.Entity<Grad>().HasData(
                new Grad()
                {
                    GradId = 1,
                    NazivGrada = "Sarajevo",
                    PostanskiBroj = "71000"
                });
            #endregion
           
            #region Dodavanje artikala
            modelBuilder.Entity<Fotograf>().HasData(
                new Fotograf()
                {
                    FotografId = 1,
                    Slika = File.ReadAllBytes("trenerka1.jpg"),
                    TipFotografaId = 1,
                    DnevnaCijena = 20,
                    Ime = "Fotograf",
                    Prezime = "Test",
                    Status = true,
                }
                );
            #endregion

            #region Dodavanje korisnika
            modelBuilder.Entity<Korisnik>().HasData(
                new Korisnik()
                {
                    KorisnikId = 2002,
                    Ime = "hanna",
                    Prezime = "hanna",
                    Email = "hanna@example.com",
                    Telefon = "123",
                    Username = "hanna",
                    PasswordSalt = Salt[0],
                    PasswordHash = HashGenerator.GenerateHash(Salt[0], "hanna"),
                    GradId = 1,
                    TipKorisnikaId = 1,
                }
               );
            #endregion


        }
    }
}
