using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestingSQLRelationships.Migrations
{
    /// <inheritdoc />
    public partial class RandomQuestionTry4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CSInterestUser_AspNetUsers_SlackId",
                table: "CSInterestUser");

            migrationBuilder.DropForeignKey(
                name: "FK_CSInterestUser_CSInterest_CSInterestId",
                table: "CSInterestUser");

            migrationBuilder.DropForeignKey(
                name: "FK_HobbyUser_AspNetUsers_SlackId",
                table: "HobbyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_HobbyUser_Hobby_HobbyId",
                table: "HobbyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_NaturalLanguageUser_AspNetUsers_SlackId",
                table: "NaturalLanguageUser");

            migrationBuilder.DropForeignKey(
                name: "FK_NaturalLanguageUser_NaturalLanguages_NaturalLanguageId",
                table: "NaturalLanguageUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgrammingLanguageUser_AspNetUsers_SlackId",
                table: "ProgrammingLanguageUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgrammingLanguageUser_ProgrammingLanguages_ProgrammingLanguageId",
                table: "ProgrammingLanguageUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgrammingLanguageUser",
                table: "ProgrammingLanguageUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NaturalLanguageUser",
                table: "NaturalLanguageUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HobbyUser",
                table: "HobbyUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hobby",
                table: "Hobby");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CSInterestUser",
                table: "CSInterestUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CSInterest",
                table: "CSInterest");

            migrationBuilder.RenameTable(
                name: "ProgrammingLanguageUser",
                newName: "ProgrammingLanguageUsers");

            migrationBuilder.RenameTable(
                name: "NaturalLanguageUser",
                newName: "NaturalLanguageUsers");

            migrationBuilder.RenameTable(
                name: "HobbyUser",
                newName: "HobbyUsers");

            migrationBuilder.RenameTable(
                name: "Hobby",
                newName: "Hobbies");

            migrationBuilder.RenameTable(
                name: "CSInterestUser",
                newName: "CSInterestUsers");

            migrationBuilder.RenameTable(
                name: "CSInterest",
                newName: "CSInterests");

            migrationBuilder.RenameIndex(
                name: "IX_ProgrammingLanguageUser_ProgrammingLanguageId",
                table: "ProgrammingLanguageUsers",
                newName: "IX_ProgrammingLanguageUsers_ProgrammingLanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_NaturalLanguageUser_NaturalLanguageId",
                table: "NaturalLanguageUsers",
                newName: "IX_NaturalLanguageUsers_NaturalLanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_HobbyUser_HobbyId",
                table: "HobbyUsers",
                newName: "IX_HobbyUsers_HobbyId");

            migrationBuilder.RenameIndex(
                name: "IX_CSInterestUser_CSInterestId",
                table: "CSInterestUsers",
                newName: "IX_CSInterestUsers_CSInterestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgrammingLanguageUsers",
                table: "ProgrammingLanguageUsers",
                columns: new[] { "SlackId", "ProgrammingLanguageId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_NaturalLanguageUsers",
                table: "NaturalLanguageUsers",
                columns: new[] { "SlackId", "NaturalLanguageId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_HobbyUsers",
                table: "HobbyUsers",
                columns: new[] { "SlackId", "HobbyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hobbies",
                table: "Hobbies",
                column: "HobbyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CSInterestUsers",
                table: "CSInterestUsers",
                columns: new[] { "SlackId", "CSInterestId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CSInterests",
                table: "CSInterests",
                column: "CSInterestId");

            migrationBuilder.CreateTable(
                name: "QuestionAnswerBlocks",
                columns: table => new
                {
                    QuestionAnswerBlockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlackId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserSlackId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    QuestionString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnswerString = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAnswerBlocks", x => x.QuestionAnswerBlockId);
                    table.ForeignKey(
                        name: "FK_QuestionAnswerBlocks_AspNetUsers_UserSlackId",
                        column: x => x.UserSlackId,
                        principalTable: "AspNetUsers",
                        principalColumn: "SlackId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionString = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

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

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "QuestionString" },
                values: new object[,]
                {
                    { 1, "What is your dream job?" },
                    { 2, "What is your biggest fear?" },
                    { 3, "What did you want to be when you were small?" },
                    { 4, "If you could only eat one meal for the rest of your life, what would it be?" },
                    { 5, "If you were a super-hero, what powers would you have?" },
                    { 6, "If you could go back in time to change one thing, what would it be?" },
                    { 7, "What was the last book you read?" },
                    { 8, "What is your favorite childhood memory?" },
                    { 9, "Which of the five senses would you say is your strongest?" },
                    { 10, "What three things do you think of the most each day?" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswerBlocks_UserSlackId",
                table: "QuestionAnswerBlocks",
                column: "UserSlackId");

            migrationBuilder.AddForeignKey(
                name: "FK_CSInterestUsers_AspNetUsers_SlackId",
                table: "CSInterestUsers",
                column: "SlackId",
                principalTable: "AspNetUsers",
                principalColumn: "SlackId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CSInterestUsers_CSInterests_CSInterestId",
                table: "CSInterestUsers",
                column: "CSInterestId",
                principalTable: "CSInterests",
                principalColumn: "CSInterestId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HobbyUsers_AspNetUsers_SlackId",
                table: "HobbyUsers",
                column: "SlackId",
                principalTable: "AspNetUsers",
                principalColumn: "SlackId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HobbyUsers_Hobbies_HobbyId",
                table: "HobbyUsers",
                column: "HobbyId",
                principalTable: "Hobbies",
                principalColumn: "HobbyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NaturalLanguageUsers_AspNetUsers_SlackId",
                table: "NaturalLanguageUsers",
                column: "SlackId",
                principalTable: "AspNetUsers",
                principalColumn: "SlackId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NaturalLanguageUsers_NaturalLanguages_NaturalLanguageId",
                table: "NaturalLanguageUsers",
                column: "NaturalLanguageId",
                principalTable: "NaturalLanguages",
                principalColumn: "NaturalLanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgrammingLanguageUsers_AspNetUsers_SlackId",
                table: "ProgrammingLanguageUsers",
                column: "SlackId",
                principalTable: "AspNetUsers",
                principalColumn: "SlackId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgrammingLanguageUsers_ProgrammingLanguages_ProgrammingLanguageId",
                table: "ProgrammingLanguageUsers",
                column: "ProgrammingLanguageId",
                principalTable: "ProgrammingLanguages",
                principalColumn: "ProgrammingLanguageId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CSInterestUsers_AspNetUsers_SlackId",
                table: "CSInterestUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_CSInterestUsers_CSInterests_CSInterestId",
                table: "CSInterestUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_HobbyUsers_AspNetUsers_SlackId",
                table: "HobbyUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_HobbyUsers_Hobbies_HobbyId",
                table: "HobbyUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_NaturalLanguageUsers_AspNetUsers_SlackId",
                table: "NaturalLanguageUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_NaturalLanguageUsers_NaturalLanguages_NaturalLanguageId",
                table: "NaturalLanguageUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgrammingLanguageUsers_AspNetUsers_SlackId",
                table: "ProgrammingLanguageUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgrammingLanguageUsers_ProgrammingLanguages_ProgrammingLanguageId",
                table: "ProgrammingLanguageUsers");

            migrationBuilder.DropTable(
                name: "QuestionAnswerBlocks");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgrammingLanguageUsers",
                table: "ProgrammingLanguageUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NaturalLanguageUsers",
                table: "NaturalLanguageUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HobbyUsers",
                table: "HobbyUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hobbies",
                table: "Hobbies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CSInterestUsers",
                table: "CSInterestUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CSInterests",
                table: "CSInterests");

            migrationBuilder.RenameTable(
                name: "ProgrammingLanguageUsers",
                newName: "ProgrammingLanguageUser");

            migrationBuilder.RenameTable(
                name: "NaturalLanguageUsers",
                newName: "NaturalLanguageUser");

            migrationBuilder.RenameTable(
                name: "HobbyUsers",
                newName: "HobbyUser");

            migrationBuilder.RenameTable(
                name: "Hobbies",
                newName: "Hobby");

            migrationBuilder.RenameTable(
                name: "CSInterestUsers",
                newName: "CSInterestUser");

            migrationBuilder.RenameTable(
                name: "CSInterests",
                newName: "CSInterest");

            migrationBuilder.RenameIndex(
                name: "IX_ProgrammingLanguageUsers_ProgrammingLanguageId",
                table: "ProgrammingLanguageUser",
                newName: "IX_ProgrammingLanguageUser_ProgrammingLanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_NaturalLanguageUsers_NaturalLanguageId",
                table: "NaturalLanguageUser",
                newName: "IX_NaturalLanguageUser_NaturalLanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_HobbyUsers_HobbyId",
                table: "HobbyUser",
                newName: "IX_HobbyUser_HobbyId");

            migrationBuilder.RenameIndex(
                name: "IX_CSInterestUsers_CSInterestId",
                table: "CSInterestUser",
                newName: "IX_CSInterestUser_CSInterestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgrammingLanguageUser",
                table: "ProgrammingLanguageUser",
                columns: new[] { "SlackId", "ProgrammingLanguageId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_NaturalLanguageUser",
                table: "NaturalLanguageUser",
                columns: new[] { "SlackId", "NaturalLanguageId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_HobbyUser",
                table: "HobbyUser",
                columns: new[] { "SlackId", "HobbyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hobby",
                table: "Hobby",
                column: "HobbyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CSInterestUser",
                table: "CSInterestUser",
                columns: new[] { "SlackId", "CSInterestId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CSInterest",
                table: "CSInterest",
                column: "CSInterestId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "8UJBW6F3",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "f1fe7ec0-8db7-4000-93ea-d3697809793c", "68b1879e-c2a4-484d-ace9-fcfa72a489ec", "215faca7-2420-4777-9fef-fc717f37a5b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "U73VQP71",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "abcc4705-5d1b-4921-aacf-fb8fb93b618e", "b6a8f041-5523-4bbf-83af-1a58db06e90f", "2ace5d99-3a9e-4bf1-9cfd-9ed590b70641" });

            migrationBuilder.AddForeignKey(
                name: "FK_CSInterestUser_AspNetUsers_SlackId",
                table: "CSInterestUser",
                column: "SlackId",
                principalTable: "AspNetUsers",
                principalColumn: "SlackId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CSInterestUser_CSInterest_CSInterestId",
                table: "CSInterestUser",
                column: "CSInterestId",
                principalTable: "CSInterest",
                principalColumn: "CSInterestId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HobbyUser_AspNetUsers_SlackId",
                table: "HobbyUser",
                column: "SlackId",
                principalTable: "AspNetUsers",
                principalColumn: "SlackId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HobbyUser_Hobby_HobbyId",
                table: "HobbyUser",
                column: "HobbyId",
                principalTable: "Hobby",
                principalColumn: "HobbyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NaturalLanguageUser_AspNetUsers_SlackId",
                table: "NaturalLanguageUser",
                column: "SlackId",
                principalTable: "AspNetUsers",
                principalColumn: "SlackId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NaturalLanguageUser_NaturalLanguages_NaturalLanguageId",
                table: "NaturalLanguageUser",
                column: "NaturalLanguageId",
                principalTable: "NaturalLanguages",
                principalColumn: "NaturalLanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgrammingLanguageUser_AspNetUsers_SlackId",
                table: "ProgrammingLanguageUser",
                column: "SlackId",
                principalTable: "AspNetUsers",
                principalColumn: "SlackId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgrammingLanguageUser_ProgrammingLanguages_ProgrammingLanguageId",
                table: "ProgrammingLanguageUser",
                column: "ProgrammingLanguageId",
                principalTable: "ProgrammingLanguages",
                principalColumn: "ProgrammingLanguageId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
