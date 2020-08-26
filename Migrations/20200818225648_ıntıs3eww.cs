using Microsoft.EntityFrameworkCore.Migrations;

namespace OnOnePageVuejs.Migrations
{
    public partial class ıntıs3eww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "products");
        }
    }
}
