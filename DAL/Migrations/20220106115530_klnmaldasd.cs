using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class klnmaldasd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "SupplierOperations",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "SupplierOperations");
        }
    }
}
