using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestingSQLRelationships.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    SlackId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CareerPhase = table.Column<int>(type: "int", nullable: false),
                    ExperienceLevel = table.Column<int>(type: "int", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("User_SlackId", x => x.SlackId);
                });

            migrationBuilder.CreateTable(
                name: "NaturalLanguages",
                columns: table => new
                {
                    NaturalLanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaturalLanguages", x => x.NaturalLanguageId);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammingLanguages",
                columns: table => new
                {
                    ProgrammingLanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguages", x => x.ProgrammingLanguageId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "SlackId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "SlackId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "SlackId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "SlackId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NaturalLanguageUser",
                columns: table => new
                {
                    SlackId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NaturalLanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaturalLanguageUser", x => new { x.SlackId, x.NaturalLanguageId });
                    table.ForeignKey(
                        name: "FK_NaturalLanguageUser_AspNetUsers_SlackId",
                        column: x => x.SlackId,
                        principalTable: "AspNetUsers",
                        principalColumn: "SlackId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NaturalLanguageUser_NaturalLanguages_NaturalLanguageId",
                        column: x => x.NaturalLanguageId,
                        principalTable: "NaturalLanguages",
                        principalColumn: "NaturalLanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammingLanguageUser",
                columns: table => new
                {
                    SlackId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProgrammingLanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguageUser", x => new { x.SlackId, x.ProgrammingLanguageId });
                    table.ForeignKey(
                        name: "FK_ProgrammingLanguageUser_AspNetUsers_SlackId",
                        column: x => x.SlackId,
                        principalTable: "AspNetUsers",
                        principalColumn: "SlackId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgrammingLanguageUser_ProgrammingLanguages_ProgrammingLanguageId",
                        column: x => x.ProgrammingLanguageId,
                        principalTable: "ProgrammingLanguages",
                        principalColumn: "ProgrammingLanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "SlackId", "AccessFailedCount", "Bio", "CareerPhase", "ConcurrencyStamp", "Email", "EmailConfirmed", "ExperienceLevel", "Gender", "Id", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "U73VQP71", 0, "Hello, my name is John. I am interested in AI.", 2, "6cba1546-7887-4523-8e96-a92802844bbe", null, false, 2, 0, "b17b800a-07ae-4b09-9ee1-94c858912b92", false, null, null, null, null, null, false, "f3865c75-ef60-451a-9b04-7ae27de25739", false, null });

            migrationBuilder.InsertData(
                table: "NaturalLanguages",
                columns: new[] { "NaturalLanguageId", "Name" },
                values: new object[,]
                {
                    { 1, "Akan" },
                    { 2, "Amharic" },
                    { 3, "Arabic" },
                    { 4, "Assamese" },
                    { 5, "Awadhi" },
                    { 6, "Azerbaijani" },
                    { 7, "Balochi" },
                    { 8, "Belarusian" },
                    { 9, "Bengali" },
                    { 10, "Bhojpuri" },
                    { 11, "Burmese" },
                    { 12, "Cebuano" },
                    { 13, "Chewa" },
                    { 14, "Chhattisgarhi" },
                    { 15, "Chittagonian" },
                    { 16, "Czech" },
                    { 17, "Deccan" },
                    { 18, "Dhundhari" },
                    { 19, "Dutch" },
                    { 20, "Eastern_Min" },
                    { 21, "English" },
                    { 22, "French" },
                    { 23, "Fula" },
                    { 24, "Gan_Chinese" },
                    { 25, "German" },
                    { 26, "Greek" },
                    { 27, "Gujarati" },
                    { 28, "Haitian_Creole" },
                    { 29, "Hakka" },
                    { 30, "Haryanvi" },
                    { 31, "Hausa" },
                    { 32, "Hiligaynon" },
                    { 33, "Hindi" },
                    { 34, "Hmong" },
                    { 35, "Hungarian" },
                    { 36, "Igbo" },
                    { 37, "Ilocano" },
                    { 38, "Italian" },
                    { 39, "Japanese" },
                    { 40, "Javanese" },
                    { 41, "Jin" },
                    { 42, "Kannada" },
                    { 43, "Kazakh" },
                    { 44, "Khmer" },
                    { 45, "Kinyarwanda" },
                    { 46, "Kirundi" },
                    { 47, "Konkani" },
                    { 48, "Korean" },
                    { 49, "Kurdish" },
                    { 50, "Madurese" },
                    { 51, "Magahi" },
                    { 52, "Maithili" },
                    { 53, "Malagasy" },
                    { 54, "Malay_Indonesian" },
                    { 55, "Malayalam" },
                    { 56, "Mandarin" },
                    { 57, "Marathi" },
                    { 58, "Marwari" },
                    { 59, "Mossi" },
                    { 60, "Nepali" },
                    { 61, "Northern_Min" },
                    { 62, "Odia_Oriya" },
                    { 63, "Oromo" },
                    { 64, "Pashto" },
                    { 65, "Persian" },
                    { 66, "Polish" },
                    { 67, "Portuguese" },
                    { 68, "Punjabi" },
                    { 69, "Quechua" },
                    { 70, "Romanian" },
                    { 71, "Russian" },
                    { 72, "Saraiki" },
                    { 73, "Serbo_Croatian" },
                    { 74, "Shona" },
                    { 75, "Sindhi" },
                    { 76, "Sinhalese" },
                    { 77, "Somali" },
                    { 78, "Southern_Min" },
                    { 79, "Spanish" },
                    { 80, "Sundanese" },
                    { 81, "Swedish" },
                    { 82, "Sylheti" },
                    { 83, "Tagalog" },
                    { 84, "Tamil" },
                    { 85, "Telugu" },
                    { 86, "Thai" },
                    { 87, "Turkish" },
                    { 88, "Turkmen" },
                    { 89, "Ukrainian" },
                    { 90, "Urdu" },
                    { 91, "Uyghur" },
                    { 92, "Uzbek" },
                    { 93, "Vietnamese" },
                    { 94, "Wu_inc_Shanghainese" },
                    { 95, "Xhosa" },
                    { 96, "Xiang_Hunnanese" },
                    { 97, "Yoruba" },
                    { 98, "Yue_Cantonese" },
                    { 99, "Zhuang" },
                    { 100, "Zulu" }
                });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguages",
                columns: new[] { "ProgrammingLanguageId", "Name" },
                values: new object[,]
                {
                    { 1, "Ada" },
                    { 2, "Assembly" },
                    { 3, "C" },
                    { 4, "COBOL" },
                    { 5, "CPlusPlus" },
                    { 6, "CSharp" },
                    { 7, "CSS" },
                    { 8, "D" },
                    { 9, "Dart" },
                    { 10, "Erlang" },
                    { 11, "Fortran" },
                    { 12, "FSharp" },
                    { 13, "Go" },
                    { 14, "HTML" },
                    { 15, "Java" },
                    { 16, "JavaScript" },
                    { 17, "Julia" },
                    { 18, "Kotlin" },
                    { 19, "Lisp" },
                    { 20, "Lua" },
                    { 21, "ObjectiveC" },
                    { 22, "Pascal" },
                    { 23, "Perl" },
                    { 24, "PHP" },
                    { 25, "Python" },
                    { 26, "Ruby" },
                    { 27, "Rust" },
                    { 28, "SQL" },
                    { 29, "Swift" },
                    { 30, "Typescript" },
                    { 31, "VisualBasic" }
                });

            migrationBuilder.InsertData(
                table: "NaturalLanguageUser",
                columns: new[] { "NaturalLanguageId", "SlackId" },
                values: new object[,]
                {
                    { 28, "U73VQP71" },
                    { 45, "U73VQP71" },
                    { 89, "U73VQP71" }
                });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguageUser",
                columns: new[] { "ProgrammingLanguageId", "SlackId" },
                values: new object[,]
                {
                    { 3, "U73VQP71" },
                    { 5, "U73VQP71" },
                    { 6, "U73VQP71" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NaturalLanguageUser_NaturalLanguageId",
                table: "NaturalLanguageUser",
                column: "NaturalLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammingLanguageUser_ProgrammingLanguageId",
                table: "ProgrammingLanguageUser",
                column: "ProgrammingLanguageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "NaturalLanguageUser");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguageUser");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "NaturalLanguages");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguages");
        }
    }
}
