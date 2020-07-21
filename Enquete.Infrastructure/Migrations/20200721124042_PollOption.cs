using Microsoft.EntityFrameworkCore.Migrations;

namespace Enquete.Infrastructure.Migrations
{
    public partial class PollOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PollOption",
                columns: table => new
                {
                    PollId = table.Column<int>(nullable: false),
                    OptionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PollOption", x => new { x.PollId, x.OptionId });
                    table.UniqueConstraint("AK_PollOption_OptionId_PollId", x => new { x.OptionId, x.PollId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PollOption");
        }
    }
}
