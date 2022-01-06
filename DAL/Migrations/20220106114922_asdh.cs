using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class asdh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "theRest",
                table: "SupplierOperations",
                newName: "TheRest");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TheRest",
                table: "SupplierOperations",
                newName: "theRest");
        }
    }
}
