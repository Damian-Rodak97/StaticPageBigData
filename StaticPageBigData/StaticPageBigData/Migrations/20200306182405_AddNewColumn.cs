using Microsoft.EntityFrameworkCore.Migrations;

namespace StaticPageBigData.Migrations
{
    public partial class AddNewColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "UrlModels",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "UrlModels");
        }
    }
}
