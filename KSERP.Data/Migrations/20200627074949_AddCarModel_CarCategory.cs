using Microsoft.EntityFrameworkCore.Migrations;

namespace KSERP.Data.Migrations
{
    public partial class AddCarModel_CarCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    BrandId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarCategories_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarColors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    EnglishName = table.Column<string>(nullable: true),
                    HEXCode = table.Column<string>(maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarColors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(maxLength: 50, nullable: true),
                    GearBox = table.Column<string>(maxLength: 50, nullable: true),
                    YOM = table.Column<int>(nullable: false, defaultValue: 0),
                    MY = table.Column<int>(nullable: false, defaultValue: 0),
                    SalesPrice = table.Column<long>(nullable: false, defaultValue: 0L),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarCategoryColors",
                columns: table => new
                {
                    CarCategoryId = table.Column<int>(nullable: false),
                    CarColorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCategoryColors", x => new { x.CarCategoryId, x.CarColorId });
                    table.ForeignKey(
                        name: "FK_CarCategoryColors_CarCategories_CarCategoryId",
                        column: x => x.CarCategoryId,
                        principalTable: "CarCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarCategoryColors_CarColors_CarColorId",
                        column: x => x.CarColorId,
                        principalTable: "CarColors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarModelCategories",
                columns: table => new
                {
                    CarCategoryId = table.Column<int>(nullable: false),
                    CarModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModelCategories", x => new { x.CarCategoryId, x.CarModelId });
                    table.ForeignKey(
                        name: "FK_CarModelCategories_CarCategories_CarCategoryId",
                        column: x => x.CarCategoryId,
                        principalTable: "CarCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarModelCategories_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarModelColors",
                columns: table => new
                {
                    CarModelId = table.Column<int>(nullable: false),
                    CarColorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModelColors", x => new { x.CarColorId, x.CarModelId });
                    table.ForeignKey(
                        name: "FK_CarModelColors_CarColors_CarColorId",
                        column: x => x.CarColorId,
                        principalTable: "CarColors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarModelColors_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarCategories_BrandId",
                table: "CarCategories",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_CarCategoryColors_CarColorId",
                table: "CarCategoryColors",
                column: "CarColorId");

            migrationBuilder.CreateIndex(
                name: "IX_CarModelCategories_CarModelId",
                table: "CarModelCategories",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CarModelColors_CarModelId",
                table: "CarModelColors",
                column: "CarModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarCategoryColors");

            migrationBuilder.DropTable(
                name: "CarModelCategories");

            migrationBuilder.DropTable(
                name: "CarModelColors");

            migrationBuilder.DropTable(
                name: "CarCategories");

            migrationBuilder.DropTable(
                name: "CarColors");

            migrationBuilder.DropTable(
                name: "CarModels");
        }
    }
}
