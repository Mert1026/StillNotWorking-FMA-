using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceManagementApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixingTheDB_ForeignKeysChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_IncomeHistory_IncomeHistoryId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_PaymentHistories_PaymentHistoryId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_TransactionHistories_TransactionHistoryId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_IncomeHistoryId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_PaymentHistoryId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_TransactionHistoryId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "IncomeHistoryId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "PaymentHistoryId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "TransactionHistoryId",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "TransactionHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "PaymentHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "IncomeHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionHistories_AccountId",
                table: "TransactionHistories",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentHistories_AccountId",
                table: "PaymentHistories",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeHistory_AccountId",
                table: "IncomeHistory",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeHistory_Accounts_AccountId",
                table: "IncomeHistory",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentHistories_Accounts_AccountId",
                table: "PaymentHistories",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionHistories_Accounts_AccountId",
                table: "TransactionHistories",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncomeHistory_Accounts_AccountId",
                table: "IncomeHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentHistories_Accounts_AccountId",
                table: "PaymentHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionHistories_Accounts_AccountId",
                table: "TransactionHistories");

            migrationBuilder.DropIndex(
                name: "IX_TransactionHistories_AccountId",
                table: "TransactionHistories");

            migrationBuilder.DropIndex(
                name: "IX_PaymentHistories_AccountId",
                table: "PaymentHistories");

            migrationBuilder.DropIndex(
                name: "IX_IncomeHistory_AccountId",
                table: "IncomeHistory");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "TransactionHistories");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "PaymentHistories");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "IncomeHistory");

            migrationBuilder.AddColumn<int>(
                name: "IncomeHistoryId",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentHistoryId",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TransactionHistoryId",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_IncomeHistoryId",
                table: "Accounts",
                column: "IncomeHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_PaymentHistoryId",
                table: "Accounts",
                column: "PaymentHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_TransactionHistoryId",
                table: "Accounts",
                column: "TransactionHistoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_IncomeHistory_IncomeHistoryId",
                table: "Accounts",
                column: "IncomeHistoryId",
                principalTable: "IncomeHistory",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_PaymentHistories_PaymentHistoryId",
                table: "Accounts",
                column: "PaymentHistoryId",
                principalTable: "PaymentHistories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_TransactionHistories_TransactionHistoryId",
                table: "Accounts",
                column: "TransactionHistoryId",
                principalTable: "TransactionHistories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
