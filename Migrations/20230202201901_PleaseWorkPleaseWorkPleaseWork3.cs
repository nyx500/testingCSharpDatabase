using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingSQLRelationships.Migrations
{
    /// <inheritdoc />
    public partial class PleaseWorkPleaseWorkPleaseWork3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Likes",
                columns: new[] { "SlackId1", "SlackId2" },
                values: new object[] { "8UJBW6F3", "U73VQP71" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumns: new[] { "SlackId1", "SlackId2" },
                keyValues: new object[] { "8UJBW6F3", "U73VQP71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "8UJBW6F3",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "8ce36339-b4f9-4262-8e15-b8908802a749", "8c088b78-1a32-403b-a0bd-b9664d436fbd", "0392a8ae-2e77-4253-b1d8-6d16d352573a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "U73VQP71",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "7fb16fa5-207b-4787-bf5b-f2f65b879455", "706ea079-c50f-42a9-b0cd-efc62f9bcbe1", "dae4b998-33c4-42e9-b3d7-d4e54bc512a3" });
        }
    }
}
