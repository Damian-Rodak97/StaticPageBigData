using Microsoft.EntityFrameworkCore.Migrations;

namespace StaticPageBigData.Migrations
{
    public partial class AddEmailAndIsHtmlColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UrlModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsHtml",
                table: "UrlModels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "UrlModels");

            migrationBuilder.DropColumn(
                name: "IsHtml",
                table: "UrlModels");
        }
    }
}
