using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoodsCatalog.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "goods",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    good_type = table.Column<int>(type: "integer", nullable: false),
                    good_manufacture = table.Column<int>(type: "integer", nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    good_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("goods_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "goods_manufacture",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("goods_manufacture_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "goods_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("goods_types_pkey", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "goods");

            migrationBuilder.DropTable(
                name: "goods_manufacture");

            migrationBuilder.DropTable(
                name: "goods_types");
        }
    }
}
