using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingSQLRelationships.Migrations
{
    /// <inheritdoc />
    public partial class AddIsMatchToLikesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMatch",
                table: "Likes",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumns: new[] { "Liker User", "Liked User" },
                keyValues: new object[] { "8UJBW6F3", "U73VQP71" },
                column: "IsMatch",
                value: false);

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumns: new[] { "Liker User", "Liked User" },
                keyValues: new object[] { "U73VQP71", "8UJBW6F3" },
                column: "IsMatch",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMatch",
                table: "Likes");

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
        }
    }
}
