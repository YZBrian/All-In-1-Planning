using Microsoft.EntityFrameworkCore.Migrations;

namespace All_In_1_Planning.Migrations
{
    public partial class AddEventHasPriority : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasPriority",
                table: "Events",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasPriority",
                table: "Events");
        }
    }
}
