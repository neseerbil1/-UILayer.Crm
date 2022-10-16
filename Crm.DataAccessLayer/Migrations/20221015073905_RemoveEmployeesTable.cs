using Microsoft.EntityFrameworkCore.Migrations;

namespace Crm.DataAccessLayer.Migrations
{
    public partial class RemoveEmployeesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeBirth = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    EmployeeGender = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    EmployeeMail = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    EmployeeName = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    EmployeePassword = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    EmployeeSurname = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });
        }
    }
}
