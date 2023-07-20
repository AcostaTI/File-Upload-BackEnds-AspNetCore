using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMVC.Migrations
{
    public partial class alteracaotabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Formato",
                table: "Arquivos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Formato",
                table: "Arquivos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
