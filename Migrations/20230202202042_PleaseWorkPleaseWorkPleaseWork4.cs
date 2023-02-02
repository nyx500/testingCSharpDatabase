using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingSQLRelationships.Migrations
{
    /// <inheritdoc />
    public partial class PleaseWorkPleaseWorkPleaseWork4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_AspNetUsers_SlackId1",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_AspNetUsers_SlackId2",
                table: "Likes");

            migrationBuilder.RenameColumn(
                name: "SlackId2",
                table: "Likes",
                newName: "Liked User");

            migrationBuilder.RenameColumn(
                name: "SlackId1",
                table: "Likes",
                newName: "Liker User");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_SlackId2",
                table: "Likes",
                newName: "IX_Likes_Liked User");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_AspNetUsers_Liked User",
                table: "Likes",
                column: "Liked User",
                principalTable: "AspNetUsers",
                principalColumn: "SlackId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_AspNetUsers_Liker User",
                table: "Likes",
                column: "Liker User",
                principalTable: "AspNetUsers",
                principalColumn: "SlackId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_AspNetUsers_Liked User",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_AspNetUsers_Liker User",
                table: "Likes");

            migrationBuilder.RenameColumn(
                name: "Liked User",
                table: "Likes",
                newName: "SlackId2");

            migrationBuilder.RenameColumn(
                name: "Liker User",
                table: "Likes",
                newName: "SlackId1");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_Liked User",
                table: "Likes",
                newName: "IX_Likes_SlackId2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "8UJBW6F3",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "7b487d57-7668-4330-90bc-9b706f2db7d4", "153dc8a8-a0f2-485e-80c4-c4229d03ac64", "452d1053-5d35-4ac9-a666-a53f95461e89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "U73VQP71",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "efa1321a-5c72-47c0-b732-809634cc0d8c", "43f0637c-5050-4c14-aaed-fd7f07acdd73", "186201a3-35ee-470b-a36a-ff6fbd9f76e1" });

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_AspNetUsers_SlackId1",
                table: "Likes",
                column: "SlackId1",
                principalTable: "AspNetUsers",
                principalColumn: "SlackId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_AspNetUsers_SlackId2",
                table: "Likes",
                column: "SlackId2",
                principalTable: "AspNetUsers",
                principalColumn: "SlackId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
