using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityInformation.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecipientInt",
                table: "Messages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SenderInt",
                table: "Messages",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecipientInt",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderInt",
                table: "Messages");
        }
    }
}
