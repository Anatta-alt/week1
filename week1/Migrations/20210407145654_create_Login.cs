using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace week1.Migrations
{
    public partial class create_Login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("42746187-92d3-4ca4-90e1-b3d36dcaeb05"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("77259142-530f-4b97-88fd-b4a8a7cf4294"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7977dddd-4ea7-4315-90de-5c3bb34c91a0"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ea1ed5ec-31eb-4f28-aaae-0d8a6974b255"));

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("559802c7-86a3-419a-8592-ceb77586c18c"), "user" },
                    { new Guid("9cdf75bf-2aec-4c2c-8323-7a755d1a9126"), "Manager" },
                    { new Guid("54ee5a17-e756-4dbe-8d70-232114564d1c"), "Admin" },
                    { new Guid("db50f6c4-9cbb-4e83-a976-f64d7db43d64"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("54ee5a17-e756-4dbe-8d70-232114564d1c"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("559802c7-86a3-419a-8592-ceb77586c18c"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9cdf75bf-2aec-4c2c-8323-7a755d1a9126"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("db50f6c4-9cbb-4e83-a976-f64d7db43d64"));

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("77259142-530f-4b97-88fd-b4a8a7cf4294"), "user" },
                    { new Guid("ea1ed5ec-31eb-4f28-aaae-0d8a6974b255"), "Manager" },
                    { new Guid("7977dddd-4ea7-4315-90de-5c3bb34c91a0"), "Admin" },
                    { new Guid("42746187-92d3-4ca4-90e1-b3d36dcaeb05"), "Developer" }
                });
        }
    }
}
