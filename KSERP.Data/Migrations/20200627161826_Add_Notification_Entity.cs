using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSERP.Data.Migrations
{
    public partial class Add_Notification_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<int>(nullable: false),
                    SentBySystem = table.Column<bool>(nullable: false),
                    SentByAdminstrator = table.Column<bool>(nullable: false),
                    ReceiverId = table.Column<int>(nullable: false),
                    Message = table.Column<string>(maxLength: 150, nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    LastChangedStatus = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");
        }
    }
}
