using Microsoft.EntityFrameworkCore.Migrations;

namespace PhotoStudio.Migrations
{
    public partial class Rezervacija_IsPlaceno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPlaceno",
                table: "Rezervacija",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Ocjena",
                table: "Rejting",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPlaceno",
                table: "Rezervacija");

            migrationBuilder.AlterColumn<int>(
                name: "Ocjena",
                table: "Rejting",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
