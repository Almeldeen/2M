using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class sasd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "EmpExpenses",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "EmpExpenses");
        }
    }
}
