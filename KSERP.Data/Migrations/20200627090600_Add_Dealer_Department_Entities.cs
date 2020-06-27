using Microsoft.EntityFrameworkCore.Migrations;

namespace KSERP.Data.Migrations
{
    public partial class Add_Dealer_Department_Entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dealers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Address = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    SalesHotline = table.Column<string>(maxLength: 15, nullable: true),
                    ServicesHotline = table.Column<string>(maxLength: 15, nullable: true),
                    BrandId = table.Column<int>(nullable: false),
                    CompanyName = table.Column<string>(maxLength: 150, nullable: true),
                    CompanyTax = table.Column<string>(maxLength: 12, nullable: true),
                    CompanyAddress = table.Column<string>(maxLength: 250, nullable: true),
                    CompanyRepresentBy = table.Column<string>(maxLength: 70, nullable: true),
                    RepresentativePosition = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dealers_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    DealerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Dealers_DealerId",
                        column: x => x.DealerId,
                        principalTable: "Dealers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dealers_BrandId",
                table: "Dealers",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DealerId",
                table: "Departments",
                column: "DealerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Dealers");
        }
    }
}
