using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeCodeDevops.Migrations
{
    /// <inheritdoc />
    public partial class createdb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "test_table_devops",
                columns: table => new
                {
                    table_id = table.Column<string>(type: "varchar(100)", nullable: false),
                    table_name = table.Column<string>(type: "varchar(100)", nullable: false),
                    table_type = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_test_table_devops", x => x.table_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "test_table_devops");
        }
    }
}
