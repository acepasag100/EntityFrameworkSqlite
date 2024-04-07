using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkSqlite.Migrations
{
    /// <inheritdoc />
    public partial class Update_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FluentApiTable",
                columns: table => new
                {
                    Indetifier = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Thatsthecolumnname = table.Column<string>(name: "Thats the column name", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentApiTable", x => x.Indetifier);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FluentApiTable");
        }
    }
}
