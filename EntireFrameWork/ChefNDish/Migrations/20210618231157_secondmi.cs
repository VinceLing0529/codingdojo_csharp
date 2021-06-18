using Microsoft.EntityFrameworkCore.Migrations;

namespace ChefNDish.Migrations
{
    public partial class secondmi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Dishes",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Dishes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Dishes");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Dishes",
                newName: "name");
        }
    }
}
