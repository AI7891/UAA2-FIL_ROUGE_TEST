using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Starter_CleanArch_UAA2.Infrastructure.Database.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NEWS_LETTER",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    newsLetter = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NEWS_LETTER", x => x.Email)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NEWS_LETTER_Email_Name_LastName_newsLetter",
                table: "NEWS_LETTER",
                columns: new[] { "Email", "Name", "LastName", "newsLetter" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NEWS_LETTER");
        }
    }
}
