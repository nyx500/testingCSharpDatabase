using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingSQLRelationships.Migrations
{
    /// <inheritdoc />
    public partial class AddRejections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rejections",
                columns: table => new
                {
                    RejectingUser = table.Column<string>(name: "Rejecting User", type: "nvarchar(450)", nullable: false),
                    RejectedUser = table.Column<string>(name: "Rejected User", type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rejections", x => new { x.RejectingUser, x.RejectedUser });
                    table.ForeignKey(
                        name: "FK_Rejections_AspNetUsers_Rejected User",
                        column: x => x.RejectedUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "SlackId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rejections_AspNetUsers_Rejecting User",
                        column: x => x.RejectingUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "SlackId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "8UJBW6F3",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "37b80888-60be-4bd2-9d6f-90e556712803", "e15fd2d9-c9ac-4c9b-9b95-4fe369d9224e", "b4726b12-f7f7-483a-aa7f-0a23dd0d6281" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "U73VQP71",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "2b2febf7-9b6b-4f14-86e1-252e8a4d2368", "94e80871-597d-463b-a506-9b5c792ac308", "76caa8d4-1412-4b9c-9d67-b30df47dc283" });

            migrationBuilder.CreateIndex(
                name: "IX_Rejections_Rejected User",
                table: "Rejections",
                column: "Rejected User");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rejections");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "8UJBW6F3",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "7aa73ba9-6e43-451e-b3b2-d965ebd49dd0", "47c63420-1ca9-43b1-8559-3817ca848e1b", "51b4229a-04fb-40f9-889b-36a05f418652" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "U73VQP71",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "665210ef-c081-4f7b-9e3b-95163424e705", "b51e101d-b7de-4f35-8fb4-150f28bc2e82", "798dcd01-e441-49f6-8a91-16421e85e8d9" });
        }
    }
}
