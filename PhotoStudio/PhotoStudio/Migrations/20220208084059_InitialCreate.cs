using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhotoStudio.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivGrada = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PostanskiBroj = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradId);
                });

            migrationBuilder.CreateTable(
                name: "TipFotografa",
                columns: table => new
                {
                    TipFotografaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipFotografa", x => x.TipFotografaId);
                });

            migrationBuilder.CreateTable(
                name: "TipKorisnika",
                columns: table => new
                {
                    TipKorisnikaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipKorisnika", x => x.TipKorisnikaId);
                });

            migrationBuilder.CreateTable(
                name: "Studio",
                columns: table => new
                {
                    StudioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivStudija = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    GradId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studio", x => x.StudioId);
                    table.ForeignKey(
                        name: "fk_Studio_Grad",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "GradId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fotograf",
                columns: table => new
                {
                    FotografId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Slika = table.Column<byte[]>(type: "binary(1)", fixedLength: true, maxLength: 1, nullable: true),
                    DnevnaCijena = table.Column<double>(type: "float", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    TipFotografaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotograf", x => x.FotografId);
                    table.ForeignKey(
                        name: "fk_Fotograf_TipFotografa",
                        column: x => x.TipFotografaId,
                        principalTable: "TipFotografa",
                        principalColumn: "TipFotografaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TipKorisnikaId = table.Column<int>(type: "int", nullable: true),
                    GradId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikId);
                    table.ForeignKey(
                        name: "fk_Korisnik_Grad",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "GradId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_Korisnik_TipKorisnika",
                        column: x => x.TipKorisnikaId,
                        principalTable: "TipKorisnika",
                        principalColumn: "TipKorisnikaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Komentar",
                columns: table => new
                {
                    KomentarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: true),
                    KorisnikId = table.Column<int>(type: "int", nullable: true),
                    FotografId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentar", x => x.KomentarId);
                    table.ForeignKey(
                        name: "fk_Fotograf_Komentar",
                        column: x => x.FotografId,
                        principalTable: "Fotograf",
                        principalColumn: "FotografId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_Korisnik_Komentar",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rejting",
                columns: table => new
                {
                    RejtingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocjena = table.Column<int>(type: "int", nullable: true),
                    KorisnikId = table.Column<int>(type: "int", nullable: true),
                    FotografId = table.Column<int>(type: "int", nullable: true),
                    DatumOcjene = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rejting", x => x.RejtingId);
                    table.ForeignKey(
                        name: "fk_Rejting_Fotograf",
                        column: x => x.FotografId,
                        principalTable: "Fotograf",
                        principalColumn: "FotografId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_Rejting_Korisnik",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    RezervacijaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumOD = table.Column<DateTime>(type: "datetime", nullable: true),
                    DatumDO = table.Column<DateTime>(type: "datetime", nullable: true),
                    KorisnikId = table.Column<int>(type: "int", nullable: true),
                    FotografId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.RezervacijaId);
                    table.ForeignKey(
                        name: "fk_Korisnik_Rezervacija",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_Rezervacija_Fotograf",
                        column: x => x.FotografId,
                        principalTable: "Fotograf",
                        principalColumn: "FotografId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fotograf_TipFotografaId",
                table: "Fotograf",
                column: "TipFotografaId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentar_FotografId",
                table: "Komentar",
                column: "FotografId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentar_KorisnikId",
                table: "Komentar",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_GradId",
                table: "Korisnik",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_TipKorisnikaId",
                table: "Korisnik",
                column: "TipKorisnikaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rejting_FotografId",
                table: "Rejting",
                column: "FotografId");

            migrationBuilder.CreateIndex(
                name: "IX_Rejting_KorisnikId",
                table: "Rejting",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_FotografId",
                table: "Rezervacija",
                column: "FotografId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_KorisnikId",
                table: "Rezervacija",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Studio_GradId",
                table: "Studio",
                column: "GradId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Komentar");

            migrationBuilder.DropTable(
                name: "Rejting");

            migrationBuilder.DropTable(
                name: "Rezervacija");

            migrationBuilder.DropTable(
                name: "Studio");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Fotograf");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "TipKorisnika");

            migrationBuilder.DropTable(
                name: "TipFotografa");
        }
    }
}
