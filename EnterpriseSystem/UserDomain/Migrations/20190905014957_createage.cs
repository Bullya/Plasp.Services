using Microsoft.EntityFrameworkCore.Migrations;

namespace UserDomain.Migrations
{
    public partial class createage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "user_info",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "user_info");
        }
    }
}
