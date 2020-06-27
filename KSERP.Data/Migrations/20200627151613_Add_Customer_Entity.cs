using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSERP.Data.Migrations
{
    public partial class Add_Customer_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 70, nullable: false),
                    Address = table.Column<string>(maxLength: 150, nullable: true),
                    PhoneNumber1 = table.Column<string>(maxLength: 15, nullable: true),
                    PhoneNumber2 = table.Column<string>(maxLength: 15, nullable: true),
                    Email = table.Column<string>(maxLength: 70, nullable: true),
                    CustomerSource = table.Column<int>(nullable: false),
                    CustomerProspect = table.Column<int>(nullable: false),
                    DoB = table.Column<DateTime>(nullable: false),
                    Job = table.Column<string>(maxLength: 150, nullable: true),
                    CurrentSalesCareId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_Employees_CurrentSalesCareId",
                        column: x => x.CurrentSalesCareId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CurrentSalesCareId",
                table: "Customer",
                column: "CurrentSalesCareId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
