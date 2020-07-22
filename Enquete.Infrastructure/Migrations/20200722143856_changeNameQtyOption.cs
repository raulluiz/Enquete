using Microsoft.EntityFrameworkCore.Migrations;

namespace Enquete.Infrastructure.Migrations
{
    public partial class changeNameQtyOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Option",
                newName: "Qty");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Qty",
                table: "Option",
                newName: "Quantity");
        }
    }
}
