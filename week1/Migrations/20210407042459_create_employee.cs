using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace week1.Migrations
{
    public partial class create_employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("69c6b657-d7ac-4e88-9391-f71b56dcbaac"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9c31f08f-0748-43ff-9cf0-a66034cf2c4e"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("d7c82575-c2ec-4065-9016-274956ff8375"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f353ae95-ecf2-401a-9133-7f648b78b6d4"));

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    IdCard = table.Column<string>(maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f155d922-f2c2-4407-aaba-c629572a1bcd"), "user" },
                    { new Guid("55be9cb9-dabf-4189-b7e7-d96a9fa2a3f7"), "Manager" },
                    { new Guid("592915af-0d1a-4e8c-a0ad-044ab81ea9ad"), "Admin" },
                    { new Guid("02818593-3345-4eb6-8a4c-40cec665b2cd"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("02818593-3345-4eb6-8a4c-40cec665b2cd"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("55be9cb9-dabf-4189-b7e7-d96a9fa2a3f7"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("592915af-0d1a-4e8c-a0ad-044ab81ea9ad"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f155d922-f2c2-4407-aaba-c629572a1bcd"));

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("69c6b657-d7ac-4e88-9391-f71b56dcbaac"), "user" },
                    { new Guid("9c31f08f-0748-43ff-9cf0-a66034cf2c4e"), "Manager" },
                    { new Guid("f353ae95-ecf2-401a-9133-7f648b78b6d4"), "Admin" },
                    { new Guid("d7c82575-c2ec-4065-9016-274956ff8375"), "Developer" }
                });
        }
    }
}
