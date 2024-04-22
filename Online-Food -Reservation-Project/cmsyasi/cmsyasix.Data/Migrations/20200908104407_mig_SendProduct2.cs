using Microsoft.EntityFrameworkCore.Migrations;

namespace cmsyasix.Data.Migrations
{
    public partial class mig_SendProduct2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "SendProduct",
                newName: "userNm");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "userNm",
                table: "SendProduct",
                newName: "UserName");
        }
    }
}
