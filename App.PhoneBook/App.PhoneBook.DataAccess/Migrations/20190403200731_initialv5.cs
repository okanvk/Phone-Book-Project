using Microsoft.EntityFrameworkCore.Migrations;

namespace App.PhoneBook.DataAccess.Migrations
{
    public partial class initialv5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employees_ParentEmployeeId",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ParentEmployeeId",
                table: "Employees",
                column: "ParentEmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employees_ParentEmployeeId",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ParentEmployeeId",
                table: "Employees",
                column: "ParentEmployeeId",
                unique: true,
                filter: "[ParentEmployeeId] IS NOT NULL");
        }
    }
}
