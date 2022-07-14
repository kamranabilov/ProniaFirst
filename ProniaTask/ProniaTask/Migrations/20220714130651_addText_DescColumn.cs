using Microsoft.EntityFrameworkCore.Migrations;

namespace ProniaTask.Migrations
{
    public partial class addText_DescColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Text_Desc",
                table: "Plants",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text_Desc",
                table: "Plants");
        }
    }
}
