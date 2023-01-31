using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingSQLRelationships.Migrations
{
    /// <inheritdoc />
    public partial class PleaseWork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "U73VQP71",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "c9c55f9e-5ca0-4204-9530-b5cde2c42f9f", "4b470f30-0b82-4cb2-b700-982e8d7b40d6", "6475e5ec-6f90-4950-96c8-c85e972b4ce4" });

            migrationBuilder.InsertData(
                table: "NaturalLanguageUser",
                columns: new[] { "NaturalLanguageId", "SlackId" },
                values: new object[] { 89, "U73VQP71" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NaturalLanguageUser",
                keyColumns: new[] { "NaturalLanguageId", "SlackId" },
                keyValues: new object[] { 89, "U73VQP71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "U73VQP71",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "13124433-01ff-4ad9-b614-9d9ba06ed686", "a264a41e-8873-4cf5-9dd4-7e57d4ba5ee8", "2c4597ce-aad5-4342-87fb-fcb5268f6d06" });
        }
    }
}
