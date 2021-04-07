using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace week1.Migrations
{
    public partial class create_client : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

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
    }
}
