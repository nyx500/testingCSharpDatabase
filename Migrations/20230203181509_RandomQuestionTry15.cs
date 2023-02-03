using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingSQLRelationships.Migrations
{
    /// <inheritdoc />
    public partial class RandomQuestionTry15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswerBlocks_AspNetUsers_UserSlackId",
                table: "QuestionAnswerBlocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionAnswerBlocks",
                table: "QuestionAnswerBlocks");

            migrationBuilder.DropIndex(
                name: "IX_QuestionAnswerBlocks_UserSlackId",
                table: "QuestionAnswerBlocks");

            migrationBuilder.DropColumn(
                name: "UserSlackId",
                table: "QuestionAnswerBlocks");

            migrationBuilder.AlterColumn<string>(
                name: "SlackId",
                table: "QuestionAnswerBlocks",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "QuestionAnswerBlockId",
                table: "QuestionAnswerBlocks",
                column: "QuestionAnswerBlockId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "8UJBW6F3",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "11a9e460-842a-4cca-95b6-c2c4cb5f5f93", "5a9d0dfb-955e-4fe3-ba58-39d19133e0b2", "00f267ca-282d-4e6d-b663-0f942d6468a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "U73VQP71",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "f29e70e3-bf39-498c-a885-1d01b99212cf", "4751e04b-fb02-4a5d-a117-0324bb1d5a5a", "a9c5c518-d554-413f-a75b-a7caf1c9cd3e" });

            migrationBuilder.InsertData(
                table: "QuestionAnswerBlocks",
                columns: new[] { "QuestionAnswerBlockId", "AnswerString", "QuestionString", "SlackId" },
                values: new object[] { 1, "Cats, coding, food", "What three things do you think of the most each day?", "U73VQP71" });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswerBlocks_SlackId",
                table: "QuestionAnswerBlocks",
                column: "SlackId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswerBlocks_AspNetUsers_SlackId",
                table: "QuestionAnswerBlocks",
                column: "SlackId",
                principalTable: "AspNetUsers",
                principalColumn: "SlackId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswerBlocks_AspNetUsers_SlackId",
                table: "QuestionAnswerBlocks");

            migrationBuilder.DropPrimaryKey(
                name: "QuestionAnswerBlockId",
                table: "QuestionAnswerBlocks");

            migrationBuilder.DropIndex(
                name: "IX_QuestionAnswerBlocks_SlackId",
                table: "QuestionAnswerBlocks");

            migrationBuilder.DeleteData(
                table: "QuestionAnswerBlocks",
                keyColumn: "QuestionAnswerBlockId",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "SlackId",
                table: "QuestionAnswerBlocks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserSlackId",
                table: "QuestionAnswerBlocks",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionAnswerBlocks",
                table: "QuestionAnswerBlocks",
                column: "QuestionAnswerBlockId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "8UJBW6F3",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "6872e216-f490-441c-8c34-4aa14a7cc00c", "8b05e1c3-dd61-4908-8d76-7b012072a6dd", "5f7f39d8-fe3c-412b-8640-3d4010ee2ab6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "U73VQP71",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "fba045fb-740c-45af-a88a-2f5e7dabb35a", "4f59c7e0-2f38-4fec-92e1-b7a304a7e2c1", "00dba039-c738-42fd-9519-b919e80114c3" });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswerBlocks_UserSlackId",
                table: "QuestionAnswerBlocks",
                column: "UserSlackId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswerBlocks_AspNetUsers_UserSlackId",
                table: "QuestionAnswerBlocks",
                column: "UserSlackId",
                principalTable: "AspNetUsers",
                principalColumn: "SlackId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
