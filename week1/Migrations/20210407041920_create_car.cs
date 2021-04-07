using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace week1.Migrations
{
    public partial class create_car : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("22c47488-192d-4a54-ab8e-399b98a59d02"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6cf8002c-8e2f-4a61-8021-06d30b4c52f3"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8e749e4c-2f13-48c6-ba6b-56d1513ecc8b"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ed8dc3cf-611e-4174-a1e1-4f7a92efe235"));

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Fuel = table.Column<string>(nullable: true),
                    Gear = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Issell = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8e57a9ed-3dd2-4006-ba05-71b32652ff3b"), "user" },
                    { new Guid("fcad9478-9af2-4194-9c75-c66d04aba331"), "Manager" },
                    { new Guid("8591b76c-9dd8-4593-ab6b-e31e5d295099"), "Admin" },
                    { new Guid("ef4e079e-d423-4dfa-86ae-7f401189bf28"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8591b76c-9dd8-4593-ab6b-e31e5d295099"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8e57a9ed-3dd2-4006-ba05-71b32652ff3b"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ef4e079e-d423-4dfa-86ae-7f401189bf28"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("fcad9478-9af2-4194-9c75-c66d04aba331"));

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6cf8002c-8e2f-4a61-8021-06d30b4c52f3"), "user" },
                    { new Guid("ed8dc3cf-611e-4174-a1e1-4f7a92efe235"), "Manager" },
                    { new Guid("8e749e4c-2f13-48c6-ba6b-56d1513ecc8b"), "Admin" },
                    { new Guid("22c47488-192d-4a54-ab8e-399b98a59d02"), "Developer" }
                });
        }
    }
}
