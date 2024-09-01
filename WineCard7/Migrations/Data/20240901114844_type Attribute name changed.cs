using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineCard7.Migrations.Data
{
    /// <inheritdoc />
    public partial class typeAttributenamechanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Types",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Types",
                newName: "Type");
        }
    }
}
