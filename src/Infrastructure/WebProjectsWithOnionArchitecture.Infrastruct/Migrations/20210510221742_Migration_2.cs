using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProjectsWithOnionArchitecture.Infrastruct.Migrations
{
    public partial class Migration_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BusinessUnitId",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OdataContext",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrganizationId",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CrmUser",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusinessUnitId",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "OdataContext",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "CrmUser");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CrmUser");
        }
    }
}
