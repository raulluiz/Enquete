using Microsoft.EntityFrameworkCore.Migrations;

namespace Enquete.Infrastructure.Migrations
{
    public partial class QuantidadeOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Option",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Option");
        }
    }
}
