using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoProject.Data.Migrations
{
    public partial class AddedMembertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    EmailId = table.Column<string>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    MemberStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
