using Microsoft.EntityFrameworkCore.Migrations;

namespace ProniaTask.Migrations
{
    public partial class addIsMaintoPlantImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "PlantImages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "PlantImages");
        }
    }
}
