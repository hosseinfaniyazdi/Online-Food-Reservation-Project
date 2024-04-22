using Microsoft.EntityFrameworkCore.Migrations;

namespace cmsyasix.Data.Migrations
{
    public partial class mig_new3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNum",
                table: "SendProducts");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "SendProducts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "SendProducts");

            migrationBuilder.AddColumn<int>(
                name: "PhoneNum",
                table: "SendProducts",
                nullable: false,
                defaultValue: 0);
        }
    }
}
