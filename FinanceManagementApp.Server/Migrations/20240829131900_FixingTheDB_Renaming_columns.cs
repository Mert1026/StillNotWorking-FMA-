using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceManagementApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixingTheDB_Renaming_columns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Countries_ContinentId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Continents");

            migrationBuilder.RenameColumn(
                name: "DateOfPayment",
                table: "Payments",
                newName: "PaymentDate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Continents",
                table: "Continents",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Continents_ContinentId",
                table: "Users",
                column: "ContinentId",
                principalTable: "Continents",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Continents_ContinentId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Continents",
                table: "Continents");

            migrationBuilder.RenameTable(
                name: "Continents",
                newName: "Countries");

            migrationBuilder.RenameColumn(
                name: "PaymentDate",
                table: "Payments",
                newName: "DateOfPayment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Countries_ContinentId",
                table: "Users",
                column: "ContinentId",
                principalTable: "Countries",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
