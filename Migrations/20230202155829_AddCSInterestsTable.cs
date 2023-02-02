using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestingSQLRelationships.Migrations
{
    /// <inheritdoc />
    public partial class AddCSInterestsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CSInterest",
                columns: table => new
                {
                    CSInterestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CSInterest", x => x.CSInterestId);
                });

            migrationBuilder.CreateTable(
                name: "CSInterestUser",
                columns: table => new
                {
                    SlackId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CSInterestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CSInterestUser", x => new { x.SlackId, x.CSInterestId });
                    table.ForeignKey(
                        name: "FK_CSInterestUser_AspNetUsers_SlackId",
                        column: x => x.SlackId,
                        principalTable: "AspNetUsers",
                        principalColumn: "SlackId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CSInterestUser_CSInterest_CSInterestId",
                        column: x => x.CSInterestId,
                        principalTable: "CSInterest",
                        principalColumn: "CSInterestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "U73VQP71",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "faaa9ab4-ef33-4131-bac0-4bdcb66fa62e", "baf5f154-f121-4b40-b987-e98dcc7c48d5", "a35831b5-bf16-43de-b9c4-42b0ab53f506" });

            migrationBuilder.InsertData(
                table: "CSInterest",
                columns: new[] { "CSInterestId", "Name" },
                values: new object[,]
                {
                    { 1, "Artificial_Intelligence" },
                    { 2, "Cybersecurity" },
                    { 3, "Database_Technology" },
                    { 4, "Fintech" },
                    { 5, "Games_Development" },
                    { 6, "Graphics_Programming" },
                    { 7, "Intelligent_Signal_Processing" },
                    { 8, "Internet_of_Things" },
                    { 9, "Machine_Learning" },
                    { 10, "Mobile_Development" },
                    { 11, "Neural_Networks" },
                    { 12, "Natural_Language_Processing" },
                    { 13, "Theoretical_Computer_Science" },
                    { 14, "Web_Development" },
                    { 15, "User_Experience" },
                    { 16, "Virtual_Reality" }
                });

            migrationBuilder.InsertData(
                table: "CSInterestUser",
                columns: new[] { "CSInterestId", "SlackId" },
                values: new object[,]
                {
                    { 1, "U73VQP71" },
                    { 2, "U73VQP71" },
                    { 3, "U73VQP71" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CSInterestUser_CSInterestId",
                table: "CSInterestUser",
                column: "CSInterestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CSInterestUser");

            migrationBuilder.DropTable(
                name: "CSInterest");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "U73VQP71",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "6cba1546-7887-4523-8e96-a92802844bbe", "b17b800a-07ae-4b09-9ee1-94c858912b92", "f3865c75-ef60-451a-9b04-7ae27de25739" });
        }
    }
}
