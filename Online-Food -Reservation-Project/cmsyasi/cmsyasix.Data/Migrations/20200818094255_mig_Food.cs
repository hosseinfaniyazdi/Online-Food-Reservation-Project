using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cmsyasix.Data.Migrations
{
    public partial class mig_Food : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupId = table.Column<int>(nullable: false),
                    SubGroup = table.Column<int>(nullable: true),
                    FoodTitle = table.Column<string>(maxLength: 450, nullable: false),
                    FoodDescription = table.Column<string>(nullable: false),
                    FoodPrice = table.Column<int>(nullable: false),
                    Tags = table.Column<string>(maxLength: 600, nullable: true),
                    FoodImageName = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_Foods_FoodGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "FoodGroups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Foods_FoodGroups_SubGroup",
                        column: x => x.SubGroup,
                        principalTable: "FoodGroups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Foods_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_GroupId",
                table: "Foods",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_SubGroup",
                table: "Foods",
                column: "SubGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_UserId",
                table: "Foods",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
