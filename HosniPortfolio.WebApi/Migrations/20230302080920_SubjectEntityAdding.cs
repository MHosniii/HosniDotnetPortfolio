using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HosniPortfolio.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class SubjectEntityAdding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Lectures",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_SubjectId",
                table: "Lectures",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_Subjects_SubjectId",
                table: "Lectures",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_Subjects_SubjectId",
                table: "Lectures");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Lectures_SubjectId",
                table: "Lectures");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Lectures");
        }
    }
}
