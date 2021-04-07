using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace week1.Migrations
{
    public partial class create_customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("a60ee37f-adef-41c2-a0b6-e4069065b6e0"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("db2410cd-00dd-4716-8b23-00ef1e9fbc3e"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e8e8b53b-15f0-4671-9b1e-7f434e971baf"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f9a84888-6236-4582-9607-86a17e80dd66"));

            migrationBuilder.EnsureSchema(
                name: "sale");

            migrationBuilder.CreateTable(
                name: "Customer",
                schema: "sale",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    BankAccount = table.Column<string>(maxLength: 15, nullable: false),
                    ATMCode = table.Column<string>(maxLength: 6, nullable: false),
                    Balance = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer",
                schema: "sale");

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

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("db2410cd-00dd-4716-8b23-00ef1e9fbc3e"), "user" },
                    { new Guid("e8e8b53b-15f0-4671-9b1e-7f434e971baf"), "Manager" },
                    { new Guid("a60ee37f-adef-41c2-a0b6-e4069065b6e0"), "Admin" },
                    { new Guid("f9a84888-6236-4582-9607-86a17e80dd66"), "Developer" }
                });
        }
    }
}
