using Microsoft.EntityFrameworkCore.Migrations;

namespace evetool.db.sqlite.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "IncrementVolume",
                table: "ExpressFeeOptions",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IncrementVolume",
                table: "ExpressFeeOptions");
        }
    }
}
