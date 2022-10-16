using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Crm.DataAccessLayer.Migrations
{
    public partial class CreateEmployeesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployeeSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployeeMail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmployeePassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployeeGender = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    EmployeeBirth = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
