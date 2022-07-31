using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antra.CustomerCRM.Infrastructure.Migrations
{
    public partial class FixTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Regiosn_RegionId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Regiosn_RegionId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regiosn",
                table: "Regiosn");

            migrationBuilder.RenameTable(
                name: "Regiosn",
                newName: "Regions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regions",
                table: "Regions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Regions_RegionId",
                table: "Customers",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Regions_RegionId",
                table: "Employees",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Regions_RegionId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Regions_RegionId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regions",
                table: "Regions");

            migrationBuilder.RenameTable(
                name: "Regions",
                newName: "Regiosn");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regiosn",
                table: "Regiosn",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Regiosn_RegionId",
                table: "Customers",
                column: "RegionId",
                principalTable: "Regiosn",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Regiosn_RegionId",
                table: "Employees",
                column: "RegionId",
                principalTable: "Regiosn",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
