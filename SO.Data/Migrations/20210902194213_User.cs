using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SO.Data.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SO_USER",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "varchar(255)", nullable: false),
                    NAME = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ID", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SO_USER");
        }
    }
}
