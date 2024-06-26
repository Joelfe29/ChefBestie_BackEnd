using Microsoft.EntityFrameworkCore.Migrations;
#nullable disable

namespace ChefBestie.Data.Migrations
{
    /// <inheritdoc />
    public partial class new_ingredient_prop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "unity",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "unity",
                table: "Ingredients");
        }
    }
}
