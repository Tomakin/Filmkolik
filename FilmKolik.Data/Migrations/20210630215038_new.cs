using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Filmkolik.Data.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreatedDate", "FirstName", "LastName", "Password", "Rol", "RolString", "Username" },
                values: new object[] { 1, new DateTime(2021, 7, 1, 0, 50, 38, 430, DateTimeKind.Local).AddTicks(111), "admin", "user", "admin", 1, "Admin_Role", "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreatedDate", "FirstName", "LastName", "Password", "Rol", "RolString", "Username" },
                values: new object[] { 2, new DateTime(2021, 7, 1, 0, 50, 38, 430, DateTimeKind.Local).AddTicks(7667), "film", null, "user", 3, "FilmUser_Role", "film" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreatedDate", "FirstName", "LastName", "Password", "Rol", "RolString", "Username" },
                values: new object[] { 3, new DateTime(2021, 7, 1, 0, 50, 38, 430, DateTimeKind.Local).AddTicks(7678), "film", null, "user", 2, "StarUser_Role", "star" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
