using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeCodeDevops.Migrations
{
    /// <inheritdoc />
    public partial class feedback_note : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Feedback",
                table: "feedbacks",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Feedback",
                table: "feedbacks");
        }
    }
}
