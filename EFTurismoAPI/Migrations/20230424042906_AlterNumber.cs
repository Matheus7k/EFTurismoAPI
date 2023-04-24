using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFTurismoAPI.Migrations
{
    public partial class AlterNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Numbert",
                table: "Address",
                newName: "Number");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Address",
                newName: "Numbert");
        }
    }
}
