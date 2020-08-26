using Microsoft.EntityFrameworkCore.Migrations;

namespace OnOnePageVuejs.Migrations
{
    public partial class ınıt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "products",
                newName: "test");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "test",
                table: "products",
                newName: "Photo");
        }
    }
}
