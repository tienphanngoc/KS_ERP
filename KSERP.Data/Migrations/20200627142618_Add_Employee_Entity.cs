using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSERP.Data.Migrations
{
    public partial class Add_Employee_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 20, nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    DoB = table.Column<DateTime>(nullable: true),
                    JoinDate = table.Column<DateTime>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 15, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    IdentityCardNo = table.Column<string>(maxLength: 16, nullable: true),
                    DateOfIssue = table.Column<DateTime>(nullable: false),
                    PlaceOfIssue = table.Column<DateTime>(maxLength: 50, nullable: false),
                    ProfileImage = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PositionEmployees",
                columns: table => new
                {
                    PositionId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionEmployees", x => new { x.EmployeeId, x.PositionId });
                    table.ForeignKey(
                        name: "FK_PositionEmployees_Positions_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PositionEmployees_Employees_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PositionEmployees_PositionId",
                table: "PositionEmployees",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PositionEmployees");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
