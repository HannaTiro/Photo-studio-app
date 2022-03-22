using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PhotoStudio.Seeder;

#nullable disable

namespace PhotoStudio.Database
{
    public partial class PhotoStudioContext : DbContext
    {
        public PhotoStudioContext()
        {
        }

        public PhotoStudioContext(DbContextOptions<PhotoStudioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Fotograf> Fotografs { get; set; }
        public virtual DbSet<Grad> Grads { get; set; }
        public virtual DbSet<Komentar> Komentars { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Rejting> Rejtings { get; set; }
        public virtual DbSet<Rezervacija> Rezervacijas { get; set; }
        public virtual DbSet<Studio> Studios { get; set; }
        public virtual DbSet<TipFotografa> TipFotografas { get; set; }
        public virtual DbSet<TipKorisnika> TipKorisnikas { get; set; }
        public virtual DbSet<Novost> Novost { get; set; }
        public virtual DbSet<PosebnaPonuda> PosebnaPonuda { get; set; }
        public virtual DbSet<Usluga> Usluga { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Bosnian_Latin_100_BIN");

            modelBuilder.Entity<Fotograf>(entity =>
            {
                entity.ToTable("Fotograf");

                entity.Property(e => e.Ime).HasMaxLength(20);

                entity.Property(e => e.Opis).HasMaxLength(200);

                entity.Property(e => e.Prezime).HasMaxLength(20);

                entity.Property(e => e.Slika)
                    .IsFixedLength(false);

                entity.HasOne(d => d.TipFotografa)
                    .WithMany(p => p.Fotografs)
                    .HasForeignKey(d => d.TipFotografaId)
                    .HasConstraintName("fk_Fotograf_TipFotografa");
            });

            modelBuilder.Entity<Grad>(entity =>
            {
                entity.ToTable("Grad");

                entity.Property(e => e.NazivGrada).HasMaxLength(50);

                entity.Property(e => e.PostanskiBroj).HasMaxLength(20);
            });

            modelBuilder.Entity<Komentar>(entity =>
            {
                entity.ToTable("Komentar");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Opis).HasMaxLength(100);

                entity.HasOne(d => d.Fotograf)
                    .WithMany(p => p.Komentars)
                    .HasForeignKey(d => d.FotografId)
                    .HasConstraintName("fk_Fotograf_Komentar");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Komentars)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("fk_Korisnik_Komentar");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.ToTable("Korisnik");

                entity.Property(e => e.Email).HasMaxLength(20);

                entity.Property(e => e.Ime).HasMaxLength(20);

                entity.Property(e => e.PasswordHash).HasMaxLength(100);

                entity.Property(e => e.PasswordSalt).HasMaxLength(100);

                entity.Property(e => e.Prezime).HasMaxLength(20);

                entity.Property(e => e.Telefon).HasMaxLength(20);

                entity.Property(e => e.Username).HasMaxLength(20);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Korisniks)
                    .HasForeignKey(d => d.GradId)
                    .HasConstraintName("fk_Korisnik_Grad");

                entity.HasOne(d => d.TipKorisnika)
                    .WithMany(p => p.Korisniks)
                    .HasForeignKey(d => d.TipKorisnikaId)
                    .HasConstraintName("fk_Korisnik_TipKorisnika");
            });

            modelBuilder.Entity<Rejting>(entity =>
            {
                entity.ToTable("Rejting");

                entity.Property(e => e.DatumOcjene).HasColumnType("datetime");

                entity.HasOne(d => d.Fotograf)
                    .WithMany(p => p.Rejtings)
                    .HasForeignKey(d => d.FotografId)
                    .HasConstraintName("fk_Rejting_Fotograf");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Rejtings)
                    .HasForeignKey(d => d.KorisnikId) 
                    .HasConstraintName("fk_Rejting_Korisnik");
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.ToTable("Rezervacija");

                entity.Property(e => e.DatumDo)
                    .HasColumnType("datetime")
                    .HasColumnName("DatumDO");

                entity.Property(e => e.DatumOd)
                    .HasColumnType("datetime")
                    .HasColumnName("DatumOD");

                entity.HasOne(d => d.Fotograf)
                    .WithMany(p => p.Rezervacijas)
                    .HasForeignKey(d => d.FotografId)
                    .HasConstraintName("fk_Rezervacija_Fotograf");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Rezervacijas)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("fk_Korisnik_Rezervacija");
            });

            modelBuilder.Entity<Studio>(entity =>
            {
                entity.ToTable("Studio");

                entity.Property(e => e.Adresa).HasMaxLength(50);

                entity.Property(e => e.NazivStudija).HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(200);

                entity.Property(e => e.Telefon).HasMaxLength(20);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Studios)
                    .HasForeignKey(d => d.GradId)
                    .HasConstraintName("fk_Studio_Grad");
            });

            modelBuilder.Entity<TipFotografa>(entity =>
            {
                entity.ToTable("TipFotografa");

                entity.Property(e => e.Naziv).HasMaxLength(50);
            });

            modelBuilder.Entity<TipKorisnika>(entity =>
            {
                entity.ToTable("TipKorisnika");

                entity.Property(e => e.Tip).HasMaxLength(20);
            });
        


            OnModelCreatingPartial(modelBuilder);
            modelBuilder.Seed();
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
