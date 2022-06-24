using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class asa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpId",
                table: "EmpExpenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmpExpenses_EmpId",
                table: "EmpExpenses",
                column: "EmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpExpenses_Employees_EmpId",
                table: "EmpExpenses",
                column: "EmpId",
                principalTable: "Employees",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpExpenses_Employees_EmpId",
                table: "EmpExpenses");

            migrationBuilder.DropIndex(
                name: "IX_EmpExpenses_EmpId",
                table: "EmpExpenses");

            migrationBuilder.DropColumn(
                name: "EmpId",
                table: "EmpExpenses");
        }
    }
}
