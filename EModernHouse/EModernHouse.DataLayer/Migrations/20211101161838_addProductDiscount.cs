using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EModernHouse.DataLayer.Migrations
{
    public partial class addProductDiscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductDisCount",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Percentage = table.Column<int>(type: "int", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscountNumberUse = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDisCount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDisCount_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductDiscountUse",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDisCountId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDiscountUse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDiscountUse_ProductDisCount_ProductDisCountId",
                        column: x => x.ProductDisCountId,
                        principalTable: "ProductDisCount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductDiscountUse_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDisCount_ProductId",
                table: "ProductDisCount",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDiscountUse_ProductDisCountId",
                table: "ProductDiscountUse",
                column: "ProductDisCountId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDiscountUse_UserId",
                table: "ProductDiscountUse",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDiscountUse");

            migrationBuilder.DropTable(
                name: "ProductDisCount");
        }
    }
}
