using Microsoft.EntityFrameworkCore.Migrations;

namespace VictorBlog.Data.Migrations
{
    public partial class Blog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    IDBlog = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlogTitle = table.Column<string>(maxLength: 20, nullable: false),
                    BlogContent = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.IDBlog);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blog");
        }
    }
}
