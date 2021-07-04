using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Filmkolik.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FilmDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Not = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Score = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmDetails", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rol = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreatedDate", "FirstName", "LastName", "Password", "Rol", "Username" },
                values: new object[] { 1, new DateTime(2021, 7, 4, 11, 4, 10, 597, DateTimeKind.Local).AddTicks(341), "admin", "user", "admin", 1, "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreatedDate", "FirstName", "LastName", "Password", "Rol", "Username" },
                values: new object[] { 2, new DateTime(2021, 7, 4, 11, 4, 10, 597, DateTimeKind.Local).AddTicks(1643), "film", "user", "user", 3, "film" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreatedDate", "FirstName", "LastName", "Password", "Rol", "Username" },
                values: new object[] { 3, new DateTime(2021, 7, 4, 11, 4, 10, 597, DateTimeKind.Local).AddTicks(1647), "film", "user", "user", 2, "star" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmDetails");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
