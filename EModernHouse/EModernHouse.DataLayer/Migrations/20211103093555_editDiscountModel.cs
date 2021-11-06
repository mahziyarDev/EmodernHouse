using Microsoft.EntityFrameworkCore.Migrations;

namespace EModernHouse.DataLayer.Migrations
{
    public partial class editDiscountModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountNumberUse",
                table: "ProductDisCount");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiscountNumberUse",
                table: "ProductDisCount",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
