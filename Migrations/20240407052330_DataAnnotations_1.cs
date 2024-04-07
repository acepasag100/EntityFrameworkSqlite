using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkSqlite.Migrations
{
    /// <inheritdoc />
    public partial class DataAnnotations_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Persons",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "Table_One",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_One", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table_Three",
                columns: table => new
                {
                    Identifier = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_Three", x => x.Identifier);
                });

            migrationBuilder.CreateTable(
                name: "Table_Two",
                columns: table => new
                {
                    Table_TwoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_Two", x => x.Table_TwoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table_One");

            migrationBuilder.DropTable(
                name: "Table_Three");

            migrationBuilder.DropTable(
                name: "Table_Two");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
