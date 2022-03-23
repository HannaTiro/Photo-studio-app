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
                    Tip = "Administrator"
                },
                new TipKorisnika()
                {
                    TipKorisnikaId = 2,
                    Tip = "Korisnik"
                }
                );
            #endregion
            #region Dodavanje tipova fotografa
            modelBuilder.Entity<TipFotografa>().HasData(
                new TipFotografa()
                {
                    TipFotografaId = 1,
                    Naziv = "Vjenčanje"
                },
                new TipFotografa()
                {
                    TipFotografaId = 2,
                    Naziv = "Rođendan"
                },
                new TipFotografa()
                {
                    TipFotografaId=3,
                    Naziv="Fashion event"
                },
                new TipFotografa()
                {
                    TipFotografaId=4,
                    Naziv="Lice sa naslovnice"
                },
                new TipFotografa()
                {
                    TipFotografaId=5,
                    Naziv="Maturalna zabava"
                }
                );
            #endregion
            #region Dodavanje gradova
            modelBuilder.Entity<Grad>().HasData(
                new Grad()
                {
                    GradId = 1,
                    NazivGrada = "Mostar",
                    PostanskiBroj = "88000"
                },
                new Grad()
                {
                    GradId = 2,
                    NazivGrada = "Sarajevo",
                    PostanskiBroj = "71000"
                });
            #endregion
           
            #region Dodavanje fotografa
            modelBuilder.Entity<Fotograf>().HasData(
                new Fotograf()
                {
                    FotografId = 1,
                    Slika = File.ReadAllBytes("img/fotograf1.jpg"),
                    TipFotografaId = 1,
                    DnevnaCijena = 150,
                    Ime = "Belma",
                    Prezime = "Nukić",
                    Status = true,
                    Opis="Lets have fun"
                },
                new Fotograf()
                  {
                      FotografId = 2,
                      Slika = File.ReadAllBytes("img/fotograf2.jpg"),
                      TipFotografaId = 2,
                      DnevnaCijena = 150,
                      Ime = "Harisa",
                      Prezime = "Obradović",
                      Status = true,
                      Opis = "Book me"
                  },
                new Fotograf()
                    {
                        FotografId = 3,
                        Slika = File.ReadAllBytes("img/fotograf3.jpg"),
                        TipFotografaId = 3,
                        DnevnaCijena = 250,
                        Ime = "Hatidža",
                        Prezime = "Bojčić",
                        Status = true,
                        Opis = "Check me out on Instagram"
                    },
                new Fotograf()
                      {
                          FotografId = 4,
                          Slika = File.ReadAllBytes("img/fotograf4.jpg"),
                          TipFotografaId = 4,
                          DnevnaCijena = 250,
                          Ime = "Osman",
                          Prezime = "Maksumić",
                          Status = true,
                          Opis = "Check me out on VSCO"
                      },
                new Fotograf()
                      {
                          FotografId = 5,
                          Slika = File.ReadAllBytes("img/fotograf5.jpg"),
                          TipFotografaId = 5,
                          DnevnaCijena = 250,
                          Ime = "Manja",
                          Prezime = "Tiro",
                          Status = true,
                          Opis = "A photograph is the pause button of life"
                      },
                new Fotograf()
                       {
                           FotografId = 6,
                           Slika = File.ReadAllBytes("img/fotograf6.jpg"),
                           TipFotografaId = 1,
                           DnevnaCijena = 550,
                           Ime = "Tarik",
                           Prezime = "Sunagić",
                           Status = true,
                           Opis = "A photograph is the pause button of life"
                       },
                new Fotograf()
                       {
                           FotografId = 7,
                           Slika = File.ReadAllBytes("img/fotograf7.jpg"),
                           TipFotografaId = 3,
                           DnevnaCijena = 550,
                           Ime = "Amar",
                           Prezime = "Manjura",
                           Status = true,
                           Opis = "Check me out on IG"
                        },
                new Fotograf()
                         {
                             FotografId = 8,
                             Slika = File.ReadAllBytes("img/fotograf8.jpg"),
                             TipFotografaId = 4,
                             DnevnaCijena = 550,
                             Ime = "Faris",
                             Prezime = "Đuliman",
                             Status = true,
                             Opis = "Check me out on IG"
                         },
                new Fotograf()
                          {
                              FotografId = 9,
                              Slika = File.ReadAllBytes("img/fotograf9.jpg"),
                              TipFotografaId = 5,
                              DnevnaCijena = 370,
                              Ime = "Elvedin",
                              Prezime = "Tiro",
                              Status = true,
                              Opis = "Check me out on IG"
                          },
                new Fotograf()
                           {
                               FotografId = 10,
                               Slika = File.ReadAllBytes("img/fotograf10.jpg"),
                               TipFotografaId = 1,
                               DnevnaCijena = 800,
                               Ime = "Ajla",
                               Prezime = "Radoš",
                               Status = true,
                               Opis = "Check me out on IG"
                           }


                );
            #endregion

            #region Dodavanje korisnika
            //korisnik 1 -> admin
            Korisnik a = new Korisnik
            {
                KorisnikId = 1,
                Ime = "Hanna",
                Prezime = "Tiro",
                Email = "hanna@yahoo.com",
                Telefon = "061234432",
                Username = "admin",
                GradId = 1,
                TipKorisnikaId = 1
            };
           a.PasswordSalt = HashGenerator.GenerateSalt();
           a.PasswordHash = HashGenerator.GenerateHash(a.PasswordSalt, "admin");
            modelBuilder.Entity<Korisnik>().HasData(a);

            //Korisnik 2 -> testni

           Korisnik b= new Korisnik
            {
                KorisnikId = 2,
                Ime = "KorisnikIme",
                Prezime = "KorisnikPrezime",
                Email = "test@yahoo.com",
                Telefon = "062534635",
                Username = "test",
                GradId = 1,
                TipKorisnikaId = 2
            };
            b.PasswordSalt = HashGenerator.GenerateSalt();
            b.PasswordHash = HashGenerator.GenerateHash(b.PasswordSalt, "test");
            modelBuilder.Entity<Korisnik>().HasData(b);

            //Korisnik 3 -> testni muma
            Korisnik c = new Korisnik
            {
                KorisnikId = 3,
                Ime = "Muamer",
                Prezime = "Zukanovic",
                Email = "muma@yahoo.com",
                Telefon = "062534635",
                Username = "muma",
                GradId = 1,
                TipKorisnikaId = 2
            };
            c.PasswordSalt = HashGenerator.GenerateSalt();
            c.PasswordHash = HashGenerator.GenerateHash(c.PasswordSalt, "muma");
            modelBuilder.Entity<Korisnik>().HasData(c);

            //korisnik 4 testni lejla
            Korisnik d = new Korisnik
            {
                KorisnikId = 4,
                Ime = "Lejla",
                Prezime = "Taslaman",
                Email = "lejla@yahoo.com",
                Telefon = "062534435",
                Username = "lejla",
                GradId = 1,
                TipKorisnikaId = 2
            };
            d.PasswordSalt = HashGenerator.GenerateSalt();
            d.PasswordHash = HashGenerator.GenerateHash(d.PasswordSalt, "lejla");
            modelBuilder.Entity<Korisnik>().HasData(d);


            #endregion
            #region Dodavanje studija
            modelBuilder.Entity<Studio>().HasData(
               new Studio()
               {
                   StudioId = 1,
                   NazivStudija = "Photo studio Memories",
                   Adresa = "Splitska 7A",
                   Telefon = "061/123-432",
                   Opis = "Dozvolite nam da najljepšim nijansama obojimo Vaše najdraže životne trenutke. Kroz naš objektiv zauvijek zabilježite najdraže uspomene.",
                   GradId = 1
               }
               );
            #endregion
            #region Dodavanje Rezervacija
            modelBuilder.Entity<Rezervacija>().HasData(
             new Rezervacija()
             {
                RezervacijaId=1,
                DatumOd=new DateTime(2022,1,28),
                DatumDo=new DateTime(2022,1,29),
                KorisnikId=2,
                FotografId=2,
                IsKomentarisano=false,
                IsOcijenjeno=false,
                IsPlaceno=false
             },
              new Rezervacija()
              {
                  RezervacijaId = 2,
                  DatumOd = new DateTime(2022, 2, 18),
                  DatumDo = new DateTime(2022, 2, 20),
                  KorisnikId = 2,
                  FotografId = 3,
                  IsKomentarisano = false,
                  IsOcijenjeno = false,
                  IsPlaceno = false
              },
              new Rezervacija()
              {
                  RezervacijaId = 3,
                  DatumOd = new DateTime(2022, 2, 10),
                  DatumDo = new DateTime(2022, 2, 15),
                  KorisnikId = 3,
                  FotografId = 4,
                  IsKomentarisano = true,
                  IsOcijenjeno = true,
                  IsPlaceno = true
              },
              new Rezervacija()
              {
                  RezervacijaId = 4,
                  DatumOd = new DateTime(2021, 3, 18),
                  DatumDo = new DateTime(2021, 3, 20),
                  KorisnikId = 4,
                  FotografId = 2,
                  IsKomentarisano = false,
                  IsOcijenjeno = true,
                  IsPlaceno = true
              },
                 new Rezervacija()
                 {
                     RezervacijaId = 5,
                     DatumOd = new DateTime(2019, 1, 1),
                     DatumDo = new DateTime(2019, 1, 3),
                     KorisnikId = 4,
                     FotografId = 1,
                     IsKomentarisano = false,
                     IsOcijenjeno = true,
                     IsPlaceno = true
                 },
                 new Rezervacija()
                 {
                     RezervacijaId = 6,
                     DatumOd = new DateTime(2019, 1, 4),
                     DatumDo = new DateTime(2019, 1, 6),
                     KorisnikId = 4,
                     FotografId = 1,
                     IsKomentarisano = false,
                     IsOcijenjeno = true,
                     IsPlaceno = true
                 },
                 new Rezervacija()
                 {
                     RezervacijaId = 7,
                     DatumOd = new DateTime(2019, 1, 6),
                     DatumDo = new DateTime(2019, 1, 8),
                     KorisnikId = 4,
                     FotografId = 2,
                     IsKomentarisano = false,
                     IsOcijenjeno = true,
                     IsPlaceno = true
                 },
                 new Rezervacija()
                 {
                     RezervacijaId = 8,
                     DatumOd = new DateTime(2019, 1, 10),
                     DatumDo = new DateTime(2019, 1, 12),
                     KorisnikId = 4,
                     FotografId = 2,
                     IsKomentarisano = false,
                     IsOcijenjeno = true,
                     IsPlaceno = true
                 },
                 new Rezervacija()
                 {
                     RezervacijaId = 9,
                     DatumOd = new DateTime(2019, 1, 14),
                     DatumDo = new DateTime(2019, 1, 16),
                     KorisnikId = 4,
                     FotografId = 3,
                     IsKomentarisano = false,
                     IsOcijenjeno = true,
                     IsPlaceno = true
                 },
                 new Rezervacija()
                 {
                     RezervacijaId = 10,
                     DatumOd = new DateTime(2019, 2, 1),
                     DatumDo = new DateTime(2019, 2, 3),
                     KorisnikId = 4,
                     FotografId = 4,
                     IsKomentarisano = false,
                     IsOcijenjeno = true,
                     IsPlaceno = true
                 },
                 new Rezervacija()
                 {
                     RezervacijaId = 11,
                     DatumOd = new DateTime(2019, 3, 1),
                     DatumDo = new DateTime(2019, 3, 3),
                     KorisnikId = 4,
                     FotografId = 4,
                     IsKomentarisano = false,
                     IsOcijenjeno = true,
                     IsPlaceno = true
                 },
                 new Rezervacija()
                 {
                     RezervacijaId = 12,
                     DatumOd = new DateTime(2019, 4, 1),
                     DatumDo = new DateTime(2019, 4, 3),
                     KorisnikId = 4,
                     FotografId = 5,
                     IsKomentarisano = false,
                     IsOcijenjeno = true,
                     IsPlaceno = true
                 },
                  new Rezervacija()
                  {
                      RezervacijaId = 13,
                      DatumOd = new DateTime(2019, 4, 4),
                      DatumDo = new DateTime(2019, 4, 6),
                      KorisnikId = 4,
                      FotografId = 5,
                      IsKomentarisano = false,
                      IsOcijenjeno = true,
                      IsPlaceno = true
                  },
                    new Rezervacija()
                    {
                        RezervacijaId = 14,
                        DatumOd = new DateTime(2019, 5, 4),
                        DatumDo = new DateTime(2019, 5, 6),
                        KorisnikId = 4,
                        FotografId = 7,
                        IsKomentarisano = false,
                        IsOcijenjeno = true,
                        IsPlaceno = true
                    },
                      new Rezervacija()
                      {
                          RezervacijaId = 15,
                          DatumOd = new DateTime(2019, 5, 7),
                          DatumDo = new DateTime(2019, 5, 9),
                          KorisnikId = 4,
                          FotografId = 8,
                          IsKomentarisano = false,
                          IsOcijenjeno = true,
                          IsPlaceno = true
                      },
                         new Rezervacija()
                         {
                             RezervacijaId = 16,
                             DatumOd = new DateTime(2019, 6, 7),
                             DatumDo = new DateTime(2019, 6, 9),
                             KorisnikId = 4,
                             FotografId = 9,
                             IsKomentarisano = false,
                             IsOcijenjeno = true,
                             IsPlaceno = true
                         },
                          new Rezervacija()
                          {
                              RezervacijaId = 17,
                              DatumOd = new DateTime(2019, 7, 7),
                              DatumDo = new DateTime(2019, 7, 9),
                              KorisnikId = 4,
                              FotografId = 10,
                              IsKomentarisano = false,
                              IsOcijenjeno = true,
                              IsPlaceno = true
                          }






             );
            #endregion
            #region Dodavanje Komentara
            modelBuilder.Entity<Komentar>().HasData(
                new Komentar()
                {
                    KomentarId=1,
                    Opis="Sve preporuke, odlično iskustvo",
                    Datum=new DateTime(2022,2,16),
                    KorisnikId=3,
                    FotografId=4
                }
                );
            #endregion
            #region Dodavanje rejtinga
            modelBuilder.Entity<Rejting>().HasData(
               new Rejting()
               {
                   RejtingId = 1,
                   Ocjena = 5,
                   DatumOcjene = new DateTime(2022, 2, 16),
                   KorisnikId = 3,
                   FotografId = 4
               },
               new Rejting()
               {
                   RejtingId = 2,
                   Ocjena = 5,
                   DatumOcjene = new DateTime(2019, 1, 4),
                   KorisnikId = 4,
                   FotografId = 1
               },
                new Rejting()
                 {
                     RejtingId = 3,
                     Ocjena = 5,
                     DatumOcjene = new DateTime(2019, 1, 17),
                     KorisnikId = 4,
                     FotografId = 3
                 },
                new Rejting()
                  {
                      RejtingId = 4,
                      Ocjena = 5,
                      DatumOcjene = new DateTime(2019, 2, 4),
                      KorisnikId = 4,
                      FotografId = 4
                  },
                new Rejting()
                   {
                       RejtingId = 5,
                       Ocjena = 5,
                       DatumOcjene = new DateTime(2019, 4, 4),
                       KorisnikId = 4,
                       FotografId = 5
                   },
                 new Rejting()
                 {
                     RejtingId = 6,
                     Ocjena = 5,
                     DatumOcjene = new DateTime(2021, 3, 21),
                     KorisnikId = 4,
                     FotografId = 2
                 },
                    new Rejting()
                    {
                        RejtingId = 7,
                        Ocjena = 5,
                        DatumOcjene = new DateTime(2019, 5, 7),
                        KorisnikId = 4,
                        FotografId = 7
                    },
                      new Rejting()
                      {
                          RejtingId = 8,
                          Ocjena = 5,
                          DatumOcjene = new DateTime(2019, 5, 10),
                          KorisnikId = 4,
                          FotografId = 8
                      },
                         new Rejting()
                         {
                             RejtingId = 9,
                             Ocjena = 5,
                             DatumOcjene = new DateTime(2019, 6, 10),
                             KorisnikId = 4,
                             FotografId = 9
                         },
                             new Rejting()
                             {
                                 RejtingId = 10,
                                 Ocjena = 5,
                                 DatumOcjene = new DateTime(2019, 7, 10),
                                 KorisnikId = 4,
                                 FotografId = 10
                             }





               );
            #endregion

            #region Dodavanje novosti
            modelBuilder.Entity<Novost>().HasData(
                new Novost()
                {
                    NovostId=1,
                    DatumObjave = new DateTime(2022, 1, 28),
                    Naslov="Obavijest o otvorenju novog studija",
                    Sadrzaj="Uskoro otvaramo novi studio u Sarajevu, ostanite uz nas.",
                    StudioId=1
                    
                }
                );
            #endregion
            #region Dodavanje ponuda
            modelBuilder.Entity<PosebnaPonuda>().HasData(
                new PosebnaPonuda()
                {
                   PosebnaPonudaId = 1,
                   NazivPonude="Paket 1",
                   Opis="Rezervacijom dva fotografa na isti datum gratis Photo book",
                   StudioId=1

                },
                 new PosebnaPonuda()
                 {
                     PosebnaPonudaId = 2,
                     NazivPonude = "Paket 2",
                     Opis = "Rezervacijom tri fotografa na isti datum gratis Photo book kao i CD sa svim slikama",
                     StudioId = 1

                 }

                );
            #endregion

            #region Dodavanje usluga
            modelBuilder.Entity<Usluga>().HasData(
                new Usluga()
                {
                    UslugaId = 1,
                    Naziv = "Meki vez 15x15 (10L + korica)",
                    Cijena=28,
                    StudioId = 1

                },
                new Usluga()
                {
                    UslugaId = 2,
                    Naziv = "Meki vez 15x20 (10L + korica)",
                    Cijena = 35,
                    StudioId = 1

                },
                 new Usluga()
                 {
                     UslugaId = 3,
                     Naziv = "Meki vez 20x20 (10L + korica)",
                     Cijena = 50,
                     StudioId = 1

                 },
                  new Usluga()
                  {
                      UslugaId = 4,
                      Naziv = "Tvrdi vez 20x20 (10L)",
                      Cijena = 70,
                      StudioId = 1

                  },
                   new Usluga()
                   {
                       UslugaId = 5,
                       Naziv = "Tvrdi vez 30x20 (10L) / panorama",
                       Cijena = 85,
                       StudioId = 1

                   },
                    new Usluga()
                    {
                        UslugaId = 6,
                        Naziv = "Izrada photo booka (100 slika)",
                        Cijena = 250,
                        StudioId = 1

                    }

                );
            #endregion

            #region Dodavanje Opreme
            modelBuilder.Entity<Oprema>().HasData(
                new Oprema()
                {
                    OpremaId = 1,
                    Naziv = "Rasvjetna oprema",
                    Opis="Softbox i oprema kišobrana. Napajanje 220V",
                    Kolicina=13,
                    StudioId = 1

                },
                  new Oprema()
                  {
                      OpremaId = 2,
                      Naziv = "Pozadinska oprema",
                      Opis="Crna,cijela i zelena boja, tekstil, visina i širina podesive",
                      Kolicina = 10,
                      StudioId = 1

                  },
                    new Oprema()
                    {
                        OpremaId = 3,
                        Naziv = "Laserski printer Canon",
                        Opis="i-SENSYS LBP710CX 33ppm LAN duplex mobile print LCD color",
                        Kolicina = 3,
                        StudioId = 1

                    },
                      new Oprema()
                      {
                          OpremaId = 4,
                          Naziv = "Canon EOS 4000D",
                          Opis="Fotoaparat 18MP, Full HD videozapisi, podržana WIFI veza",
                          Kolicina = 13,
                          StudioId = 1

                      }



                );
            #endregion


        }
    }
}
