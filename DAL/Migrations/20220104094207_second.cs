using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Jop_JopId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "JpoId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "JopId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Jop_JopId",
                table: "Employees",
                column: "JopId",
                principalTable: "Jop",
                principalColumn: "JopId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Jop_JopId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "JopId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "JpoId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Jop_JopId",
                table: "Employees",
                column: "JopId",
                principalTable: "Jop",
                principalColumn: "JopId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
