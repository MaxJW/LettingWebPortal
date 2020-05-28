using Microsoft.EntityFrameworkCore.Migrations;

namespace LWCustomer.Data.Migrations
{
    public partial class EnquiredDone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enquired",
                columns: table => new
                {
                    EnquiredId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyId = table.Column<int>(nullable: false),
                    HasEnquired = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enquired", x => x.EnquiredId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enquired");
        }
    }
}
