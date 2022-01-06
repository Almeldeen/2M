using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class askndaksdas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountOperations_Accounts_AccountsAccountId",
                table: "AccountOperations");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierOperations_Suppliers_SuppliersSuppId",
                table: "SupplierOperations");

            migrationBuilder.DropIndex(
                name: "IX_SupplierOperations_SuppliersSuppId",
                table: "SupplierOperations");

            migrationBuilder.DropIndex(
                name: "IX_AccountOperations_AccountsAccountId",
                table: "AccountOperations");

            migrationBuilder.DropColumn(
                name: "SuppliersSuppId",
                table: "SupplierOperations");

            migrationBuilder.DropColumn(
                name: "AccountsAccountId",
                table: "AccountOperations");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierOperations_SuppId",
                table: "SupplierOperations",
                column: "SuppId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountOperations_AccountId",
                table: "AccountOperations",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountOperations_Accounts_AccountId",
                table: "AccountOperations",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierOperations_Suppliers_SuppId",
                table: "SupplierOperations",
                column: "SuppId",
                principalTable: "Suppliers",
                principalColumn: "SuppId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountOperations_Accounts_AccountId",
                table: "AccountOperations");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierOperations_Suppliers_SuppId",
                table: "SupplierOperations");

            migrationBuilder.DropIndex(
                name: "IX_SupplierOperations_SuppId",
                table: "SupplierOperations");

            migrationBuilder.DropIndex(
                name: "IX_AccountOperations_AccountId",
                table: "AccountOperations");

            migrationBuilder.AddColumn<int>(
                name: "SuppliersSuppId",
                table: "SupplierOperations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountsAccountId",
                table: "AccountOperations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SupplierOperations_SuppliersSuppId",
                table: "SupplierOperations",
                column: "SuppliersSuppId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountOperations_AccountsAccountId",
                table: "AccountOperations",
                column: "AccountsAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountOperations_Accounts_AccountsAccountId",
                table: "AccountOperations",
                column: "AccountsAccountId",
                principalTable: "Accounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierOperations_Suppliers_SuppliersSuppId",
                table: "SupplierOperations",
                column: "SuppliersSuppId",
                principalTable: "Suppliers",
                principalColumn: "SuppId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
