using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineCard7.Migrations.Data
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GrapeVarietys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrapeVarietys", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OriginCountrys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OriginCountrys", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OriginFederalStates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OriginFederalStates", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriceperBottle = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Winerys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Winerys", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Years",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Years", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Wines",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceID = table.Column<int>(type: "int", nullable: false),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    OriginCountryID = table.Column<int>(type: "int", nullable: false),
                    YearÎD = table.Column<int>(type: "int", nullable: false),
                    YearID = table.Column<int>(type: "int", nullable: false),
                    WineryID = table.Column<int>(type: "int", nullable: false),
                    OriginFederalStateID = table.Column<int>(type: "int", nullable: false),
                    GrapeVarietyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wines", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Wines_GrapeVarietys_GrapeVarietyID",
                        column: x => x.GrapeVarietyID,
                        principalTable: "GrapeVarietys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wines_OriginCountrys_OriginCountryID",
                        column: x => x.OriginCountryID,
                        principalTable: "OriginCountrys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wines_OriginFederalStates_OriginFederalStateID",
                        column: x => x.OriginFederalStateID,
                        principalTable: "OriginFederalStates",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wines_Prices_PriceID",
                        column: x => x.PriceID,
                        principalTable: "Prices",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wines_Types_TypeID",
                        column: x => x.TypeID,
                        principalTable: "Types",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wines_Winerys_WineryID",
                        column: x => x.WineryID,
                        principalTable: "Winerys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wines_Years_YearID",
                        column: x => x.YearID,
                        principalTable: "Years",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardWine",
                columns: table => new
                {
                    CardsID = table.Column<int>(type: "int", nullable: false),
                    WinesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardWine", x => new { x.CardsID, x.WinesID });
                    table.ForeignKey(
                        name: "FK_CardWine_Cards_CardsID",
                        column: x => x.CardsID,
                        principalTable: "Cards",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardWine_Wines_WinesID",
                        column: x => x.WinesID,
                        principalTable: "Wines",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardWine_WinesID",
                table: "CardWine",
                column: "WinesID");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_GrapeVarietyID",
                table: "Wines",
                column: "GrapeVarietyID");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_OriginCountryID",
                table: "Wines",
                column: "OriginCountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_OriginFederalStateID",
                table: "Wines",
                column: "OriginFederalStateID");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_PriceID",
                table: "Wines",
                column: "PriceID");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_TypeID",
                table: "Wines",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_WineryID",
                table: "Wines",
                column: "WineryID");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_YearID",
                table: "Wines",
                column: "YearID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardWine");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Wines");

            migrationBuilder.DropTable(
                name: "GrapeVarietys");

            migrationBuilder.DropTable(
                name: "OriginCountrys");

            migrationBuilder.DropTable(
                name: "OriginFederalStates");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Winerys");

            migrationBuilder.DropTable(
                name: "Years");
        }
    }
}
