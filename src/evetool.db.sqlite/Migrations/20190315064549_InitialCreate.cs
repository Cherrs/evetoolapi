using Microsoft.EntityFrameworkCore.Migrations;

namespace evetool.db.sqlite.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpressCareOptions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MinPrice = table.Column<decimal>(nullable: false),
                    Ratio = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpressCareOptions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ExpressFeeOptions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    FloatingVolume = table.Column<double>(nullable: false),
                    FreeVolume = table.Column<double>(nullable: false),
                    IsCare = table.Column<bool>(nullable: false),
                    CareID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpressFeeOptions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExpressFeeOptions_ExpressCareOptions_CareID",
                        column: x => x.CareID,
                        principalTable: "ExpressCareOptions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpressFeeOptions_CareID",
                table: "ExpressFeeOptions",
                column: "CareID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpressFeeOptions");

            migrationBuilder.DropTable(
                name: "ExpressCareOptions");
        }
    }
}
