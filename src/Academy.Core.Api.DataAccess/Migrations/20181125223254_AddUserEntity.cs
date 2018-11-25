using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Academy.Core.Api.DataAccess.Migrations
{
    public partial class AddUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Academy");

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Academy",
                columns: table => new
                {
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(maxLength: 1024, nullable: false),
                    FirstName = table.Column<string>(maxLength: 1024, nullable: false),
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    LastName = table.Column<string>(maxLength: 1024, nullable: true),
                    MiddleName = table.Column<string>(maxLength: 1024, nullable: true),
                    PasswordHash = table.Column<string>(maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users",
                schema: "Academy");
        }
    }
}
