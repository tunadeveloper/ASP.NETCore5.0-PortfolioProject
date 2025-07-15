using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioProject.DataAccessLayer.Migrations
{
    public partial class adds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReceiverName",
                table: "writerMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderName",
                table: "writerMessages",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiverName",
                table: "writerMessages");

            migrationBuilder.DropColumn(
                name: "SenderName",
                table: "writerMessages");
        }
    }
}
