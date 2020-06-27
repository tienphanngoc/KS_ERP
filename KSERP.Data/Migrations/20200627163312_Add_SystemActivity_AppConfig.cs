using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSERP.Data.Migrations
{
    public partial class Add_SystemActivity_AppConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "SystemActivities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FunctionId = table.Column<int>(nullable: false),
                    ActionId = table.Column<int>(nullable: false),
                    ActorId = table.Column<int>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    ClientIp = table.Column<string>(maxLength: 20, nullable: true),
                    MacAddress = table.Column<string>(maxLength: 30, nullable: true),
                    DeviceName = table.Column<string>(maxLength: 30, nullable: true),
                    OS = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemActivities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "SystemActivities");
        }
    }
}
