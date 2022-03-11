using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhotoStudio.Migrations
{
    public partial class seed_podataka_dodaci : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "TbD9+ZbIcNUQMBDapU4EFVc+bzk=", "3907rn5tAW4+vOJHdirl6w==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "5p7P79z9vSyosk6oY69O/H6ETZE=", "xogFzjRoj45Dfw9h/UrHYQ==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "tbhT0FSWM4aPfOcTafaHekDhgpI=", "+aXctUTGwBszIrw8Fy8z4g==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "q+HS+oTosEzL1dzeLTy2wloV+GI=", "L1x9Ee7QQLRQQblaQwAOhw==" });

            migrationBuilder.InsertData(
                table: "Rejting",
                columns: new[] { "RejtingId", "DatumOcjene", "FotografId", "KorisnikId", "Ocjena" },
                values: new object[,]
                {
                    { 2, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, 5 },
                    { 3, new DateTime(2019, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, 5 },
                    { 4, new DateTime(2019, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, 5 },
                    { 5, new DateTime(2019, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, 5 },
                    { 6, new DateTime(2019, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, 5 },
                    { 8, new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, 5 },
                    { 9, new DateTime(2019, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, 5 },
                    { 10, new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, 5 },
                    { 11, new DateTime(2019, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, 5 }
                });

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "RezervacijaId",
                keyValue: 3,
                column: "IsPlaceno",
                value: true);

            migrationBuilder.InsertData(
                table: "Rezervacija",
                columns: new[] { "RezervacijaId", "DatumDO", "DatumOD", "FotografId", "IsKomentarisano", "IsOcijenjeno", "IsPlaceno", "KorisnikId" },
                values: new object[,]
                {
                    { 10, new DateTime(2019, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, true, true, 4 },
                    { 11, new DateTime(2019, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false, true, true, 4 },
                    { 12, new DateTime(2019, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false, true, true, 4 },
                    { 13, new DateTime(2019, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false, true, true, 4 },
                    { 8, new DateTime(2019, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, true, true, 4 },
                    { 6, new DateTime(2019, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true, true, 4 },
                    { 5, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true, true, 4 },
                    { 9, new DateTime(2019, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, true, true, 4 },
                    { 7, new DateTime(2019, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, true, true, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rejting",
                keyColumn: "RejtingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rejting",
                keyColumn: "RejtingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rejting",
                keyColumn: "RejtingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rejting",
                keyColumn: "RejtingId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rejting",
                keyColumn: "RejtingId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rejting",
                keyColumn: "RejtingId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rejting",
                keyColumn: "RejtingId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rejting",
                keyColumn: "RejtingId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rejting",
                keyColumn: "RejtingId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "RezervacijaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "RezervacijaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "RezervacijaId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "RezervacijaId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "RezervacijaId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "RezervacijaId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "RezervacijaId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "RezervacijaId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rezervacija",
                keyColumn: "RezervacijaId",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Z8DRgzUHrGVKp73Z1LPf+pefeUI=", "fkgJdUgtABv0KnAsqxNC5w==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "LWk8PRv1ABbmcq0E7RHOs/boKKw=", "EFg5C/6n6Otp/Z+M82Jzjw==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "vuPURyvoKiyTbZ/4rDs8/z3Ib1A=", "hIyEuOzQxWEDDKabCjyX2g==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "/eOA879Y3biWXRQlssTrc17FL9k=", "InI3ECbgvVnz5v0lLGUSEw==" });

            migrationBuilder.UpdateData(
                table: "Rezervacija",
                keyColumn: "RezervacijaId",
                keyValue: 3,
                column: "IsPlaceno",
                value: false);
        }
    }
}
