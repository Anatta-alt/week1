using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace week1.Migrations
{
    public partial class create_house : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(maxLength: 20, nullable: false),
                    HouseDistric = table.Column<string>(maxLength: 50, nullable: false),
                    RoadName = table.Column<string>(maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Houses");

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
    }
}
