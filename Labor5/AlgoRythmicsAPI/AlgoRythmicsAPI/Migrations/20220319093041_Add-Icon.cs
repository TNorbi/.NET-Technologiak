using Microsoft.EntityFrameworkCore.Migrations;

namespace AlgoRythmicsAPI.Migrations
{
    public partial class AddIcon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Algorithms",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Algorithms");
        }
    }
}
