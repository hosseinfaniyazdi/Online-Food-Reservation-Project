using Microsoft.EntityFrameworkCore.Migrations;

namespace cmsyasix.Data.Migrations
{
    public partial class mig_SendProduct3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SendProduct_Orders_OrderId",
                table: "SendProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_SendProduct_Users_UserId",
                table: "SendProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SendProduct",
                table: "SendProduct");

            migrationBuilder.RenameTable(
                name: "SendProduct",
                newName: "SendProducts");

            migrationBuilder.RenameIndex(
                name: "IX_SendProduct_UserId",
                table: "SendProducts",
                newName: "IX_SendProducts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SendProduct_OrderId",
                table: "SendProducts",
                newName: "IX_SendProducts_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SendProducts",
                table: "SendProducts",
                column: "SPId");

            migrationBuilder.AddForeignKey(
                name: "FK_SendProducts_Orders_OrderId",
                table: "SendProducts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SendProducts_Users_UserId",
                table: "SendProducts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SendProducts_Orders_OrderId",
                table: "SendProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SendProducts_Users_UserId",
                table: "SendProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SendProducts",
                table: "SendProducts");

            migrationBuilder.RenameTable(
                name: "SendProducts",
                newName: "SendProduct");

            migrationBuilder.RenameIndex(
                name: "IX_SendProducts_UserId",
                table: "SendProduct",
                newName: "IX_SendProduct_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SendProducts_OrderId",
                table: "SendProduct",
                newName: "IX_SendProduct_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SendProduct",
                table: "SendProduct",
                column: "SPId");

            migrationBuilder.AddForeignKey(
                name: "FK_SendProduct_Orders_OrderId",
                table: "SendProduct",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SendProduct_Users_UserId",
                table: "SendProduct",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
