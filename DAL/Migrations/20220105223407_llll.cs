using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class llll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpExpenses_Employees_EmployeeEmpId",
                table: "EmpExpenses");

            migrationBuilder.DropIndex(
                name: "IX_EmpExpenses_EmployeeEmpId",
                table: "EmpExpenses");

            migrationBuilder.DropColumn(
                name: "EmpId",
                table: "EmpExpenses");

            migrationBuilder.DropColumn(
                name: "EmployeeEmpId",
                table: "EmpExpenses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpId",
                table: "EmpExpenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeEmpId",
                table: "EmpExpenses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpExpenses_EmployeeEmpId",
                table: "EmpExpenses",
                column: "EmployeeEmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpExpenses_Employees_EmployeeEmpId",
                table: "EmpExpenses",
                column: "EmployeeEmpId",
                principalTable: "Employees",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
