using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoodsCatalog.Migrations
{
    /// <inheritdoc />
    public partial class AddNav : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_goods_good_manufacture",
                table: "goods",
                column: "good_manufacture");

            migrationBuilder.CreateIndex(
                name: "IX_goods_good_type",
                table: "goods",
                column: "good_type");

            migrationBuilder.AddForeignKey(
                name: "FK_goods_goods_manufacture_good_manufacture",
                table: "goods",
                column: "good_manufacture",
                principalTable: "goods_manufacture",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_goods_goods_types_good_type",
                table: "goods",
                column: "good_type",
                principalTable: "goods_types",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_goods_goods_manufacture_good_manufacture",
                table: "goods");

            migrationBuilder.DropForeignKey(
                name: "FK_goods_goods_types_good_type",
                table: "goods");

            migrationBuilder.DropIndex(
                name: "IX_goods_good_manufacture",
                table: "goods");

            migrationBuilder.DropIndex(
                name: "IX_goods_good_type",
                table: "goods");
        }
    }
}
