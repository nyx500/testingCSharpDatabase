using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestingSQLRelationships.Migrations
{
    /// <inheritdoc />
    public partial class AddManyToManyRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "U73VQP71",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "87925b6f-5e04-4b96-8e24-337d7e144b4f", "1edcab42-f59a-45ca-b72d-68b89875dd7b", "a04fea51-33f4-418a-9b59-f0792c3c2276" });

            migrationBuilder.InsertData(
                table: "NaturalLanguageUser",
                columns: new[] { "NaturalLanguageId", "SlackId" },
                values: new object[,]
                {
                    { 28, "U73VQP71" },
                    { 45, "U73VQP71" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NaturalLanguageUser",
                keyColumns: new[] { "NaturalLanguageId", "SlackId" },
                keyValues: new object[] { 28, "U73VQP71" });

            migrationBuilder.DeleteData(
                table: "NaturalLanguageUser",
                keyColumns: new[] { "NaturalLanguageId", "SlackId" },
                keyValues: new object[] { 45, "U73VQP71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "SlackId",
                keyValue: "U73VQP71",
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "c9c55f9e-5ca0-4204-9530-b5cde2c42f9f", "4b470f30-0b82-4cb2-b700-982e8d7b40d6", "6475e5ec-6f90-4950-96c8-c85e972b4ce4" });
        }
    }
}
