using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingSQLRelationships.Migrations
{
    /// <inheritdoc />
    public partial class PleaseWorkPleaseWorkPleaseWork2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Likes",
                columns: new[] { "SlackId1", "SlackId2" },
                values: new object[] { "U73VQP71", "8UJBW6F3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumns: new[] { "SlackId1", "SlackId2" },
                keyValues: new object[] { "U73VQP71", "8UJBW6F3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "8UJBW6F3",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "d9ced778-3664-40ec-8be4-9d5c9c519c59", "1b4fb1e1-f4f9-4215-8eb2-a5007e0e8731", "ad2f0f1a-54d8-4410-8a3d-ec53a81e99e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "U73VQP71",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "4a1b7fd3-dc0c-4ade-8601-5c5727d58d1f", "937ce337-9ffa-41af-9cce-8775aa192c43", "0488c2a4-c8d0-4664-b49c-2e223b9fcb7b" });
        }
    }
}
