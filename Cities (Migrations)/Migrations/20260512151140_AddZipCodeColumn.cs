using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cities__Migrations_.Migrations
{
    /// <inheritdoc />
    public partial class AddZipCodeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Cities");
        }
    }
}
