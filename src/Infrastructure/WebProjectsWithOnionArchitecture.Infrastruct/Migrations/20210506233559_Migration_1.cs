using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProjectsWithOnionArchitecture.Infrastruct.Migrations
{
    public partial class Migration_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CrmAccount",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    OdataEtag = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Statecode = table.Column<int>(type: "INTEGER", nullable: false),
                    Accountid = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmAccount", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "CrmTask",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Subject = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    RegardingObjectidSalesOrderOdataBind = table.Column<string>(type: "TEXT", nullable: true),
                    Scheduledend = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    categoryOfTask = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmTask", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "CrmUser",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmUser", x => x.Guid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrmAccount");

            migrationBuilder.DropTable(
                name: "CrmTask");

            migrationBuilder.DropTable(
                name: "CrmUser");
        }
    }
}
