using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSERP.Data.Migrations
{
    public partial class Add_Customer_Care_History_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedAt",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedBy",
                table: "Customer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CustomerCareHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    SalesCareId = table.Column<int>(nullable: false),
                    DateCare = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    CustomerProspect = table.Column<int>(nullable: false),
                    ContactBy = table.Column<int>(nullable: false),
                    Content = table.Column<string>(maxLength: 200, nullable: false, defaultValue: "Chưa điền"),
                    Result = table.Column<string>(maxLength: 200, nullable: true, defaultValue: "Chưa điền")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCareHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerCareHistories_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerCareHistories_Employees_SalesCareId",
                        column: x => x.SalesCareId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCareHistories_CustomerId",
                table: "CustomerCareHistories",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCareHistories_SalesCareId",
                table: "CustomerCareHistories",
                column: "SalesCareId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerCareHistories");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "LastUpdatedAt",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "Customer");
        }
    }
}
