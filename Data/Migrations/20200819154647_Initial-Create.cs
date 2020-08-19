using Microsoft.EntityFrameworkCore.Migrations;

namespace G151210078.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    category = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    brand = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    color = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    size = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(400)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
