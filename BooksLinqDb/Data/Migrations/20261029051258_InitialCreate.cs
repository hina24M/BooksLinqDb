using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksLinqDb.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    PublicationYear = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Category", "Price", "PublicationYear", "Title" },
                values: new object[,]
                {
                    { 1, "Anders Hejlsberg", "Programming", 45.990000000000002, 2020, "The C# Programming Language" },
                    { 2, "Jon P. Smith", "Programming", 39.990000000000002, 2021, "Entity Framework Core in Action" },
                    { 3, "Robert C. Martin", "Software Engineering", 30.0, 2008, "Clean Code" },
                    { 4, "Andrew Hunt", "Software Engineering", 35.5, 2019, "The Pragmatic Programmer" },
                    { 5, "Marios Skevos", "Programming", 29.989999999999998, 2009, "LINQ in Action" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
