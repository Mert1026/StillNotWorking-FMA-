using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceManagementApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixingTheDB_TableContinetsAddedOverCountries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Countries");

            migrationBuilder.RenameColumn(
                name: "TownId",
                table: "Users",
                newName: "ContinentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ContinentId",
                table: "Users",
                column: "ContinentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Countries_ContinentId",
                table: "Users",
                column: "ContinentId",
                principalTable: "Countries",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Countries_ContinentId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ContinentId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "ContinentId",
                table: "Users",
                newName: "TownId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
