using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserDomain.Migrations
{
    public partial class intidb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user_info",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_name = table.Column<string>(type: "varchar(20)", nullable: false),
                    password = table.Column<string>(type: "varchar(20)", nullable: false),
                    sex = table.Column<int>(maxLength: 1, nullable: false),
                    native_place = table.Column<string>(type: "varchar(60)", nullable: true),
                    address = table.Column<string>(type: "varchar(60)", nullable: true),
                    phone = table.Column<string>(type: "varchar(20)", nullable: true),
                    create_time = table.Column<DateTime>(type: "datetime", nullable: false),
                    isdelete = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_info", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_info");
        }
    }
}
