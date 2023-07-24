using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FathersName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MothersName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Designation", "FathersName", "MothersName", "Name" },
                values: new object[,]
                {
                    { 10, new DateTime(1984, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Head of Software Development", "Yeasin Bhuiyan", "Moriom Begum", "Md. Mahedee Hasan" },
                    { 11, new DateTime(1990, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "Shahidul Islam", "Momtaz Begum", "Khaleda Islam" },
                    { 12, new DateTime(2017, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jr. Software Engineer", "Md. Mahedee Hasan", "Khaleda Islam", "Tahiya Hasan Arisha" },
                    { 13, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jr. Software Engineer", "Md. Mahedee Hasan", "Khaleda Islam", "Humaira Hasan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
