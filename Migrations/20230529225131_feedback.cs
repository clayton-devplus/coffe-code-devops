using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeCodeDevops.Migrations
{
    /// <inheritdoc />
    public partial class feedback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "feedbacks",
                columns: table => new
                {
                    FeedbackId = table.Column<Guid>(type: "uuid", nullable: false),
                    PresentationNote = table.Column<int>(type: "integer", nullable: false),
                    SpeakerNote = table.Column<int>(type: "integer", nullable: false),
                    NextWorkshop = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feedbacks", x => x.FeedbackId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "feedbacks");
        }
    }
}
