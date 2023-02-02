using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingSQLRelationships.Migrations
{
    /// <inheritdoc />
    public partial class PleaseWorkPleaseWorkPleaseWork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    SlackId1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SlackId2 = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => new { x.SlackId1, x.SlackId2 });
                    table.ForeignKey(
                        name: "FK_Likes_AspNetUsers_SlackId1",
                        column: x => x.SlackId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "SlackId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Likes_AspNetUsers_SlackId2",
                        column: x => x.SlackId2,
                        principalTable: "AspNetUsers",
                        principalColumn: "SlackId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "U73VQP71",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "4a1b7fd3-dc0c-4ade-8601-5c5727d58d1f", "937ce337-9ffa-41af-9cce-8775aa192c43", "0488c2a4-c8d0-4664-b49c-2e223b9fcb7b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "SlackId", "AccessFailedCount", "Bio", "CareerPhaseId", "ConcurrencyStamp", "Email", "EmailConfirmed", "ExperienceLevelId", "GenderId", "Id", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8UJBW6F3", 0, "Hello, my name is Amanda. I am interested in VR.", 1, "d9ced778-3664-40ec-8be4-9d5c9c519c59", null, false, 2, 2, "1b4fb1e1-f4f9-4215-8eb2-a5007e0e8731", false, null, null, null, null, null, false, "ad2f0f1a-54d8-4410-8a3d-ec53a81e99e9", false, null });

            migrationBuilder.CreateIndex(
                name: "IX_Likes_SlackId2",
                table: "Likes",
                column: "SlackId2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "8UJBW6F3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "U73VQP71",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "d99ba0bb-fa8e-49ae-a9c1-0ba048f8bc28", "5f9d7795-482c-4bfb-b58b-2119a006f912", "4e2f64cb-18f5-49d4-8ccd-cb5426fb252d" });
        }
    }
}
