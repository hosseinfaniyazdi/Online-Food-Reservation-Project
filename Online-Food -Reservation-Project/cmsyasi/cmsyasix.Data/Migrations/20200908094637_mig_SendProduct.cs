using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cmsyasix.Data.Migrations
{
    public partial class mig_SendProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SendProduct",
                columns: table => new
                {
                    SPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(maxLength: 200, nullable: false),
                    Address = table.Column<string>(maxLength: 700, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    PhoneNum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendProduct", x => x.SPId);
                    table.ForeignKey(
                        name: "FK_SendProduct_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SendProduct_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SendProduct_OrderId",
                table: "SendProduct",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SendProduct_UserId",
                table: "SendProduct",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SendProduct");
        }
    }
}
