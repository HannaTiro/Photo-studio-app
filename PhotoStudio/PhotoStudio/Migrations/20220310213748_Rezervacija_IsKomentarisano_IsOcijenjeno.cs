using Microsoft.EntityFrameworkCore.Migrations;

namespace PhotoStudio.Migrations
{
    public partial class Rezervacija_IsKomentarisano_IsOcijenjeno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsKomentarisano",
                table: "Rezervacija",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsOcijenjeno",
                table: "Rezervacija",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsKomentarisano",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "IsOcijenjeno",
                table: "Rezervacija");
        }
    }
}
