using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Employees.Migrations
{
    public partial class employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "EmployeedBy", "Name" },
                values: new object[] { 1, new DateTime(1991, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juno", "Stuart Bradley" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "EmployeedBy", "Name" },
                values: new object[] { 2, new DateTime(1992, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blackpool Sixth Form", "Amy Jones" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "EmployeedBy", "Name" },
                values: new object[] { 3, new DateTime(1972, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "National Savings", "Marianne Bradley" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
