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
                name: "CareerPhase",
                columns: table => new
                {
                    CareerPhaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerPhase", x => x.CareerPhaseId);
                });

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
                name: "ExperienceLevel",
                columns: table => new
                {
                    ExperienceLevelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceLevel", x => x.ExperienceLevelId);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "Hobby",
                columns: table => new
                {
                    HobbyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobby", x => x.HobbyId);
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
                name: "AspNetUsers",
                columns: table => new
                {
                    SlackId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CareerPhaseId = table.Column<int>(type: "int", nullable: false),
                    ExperienceLevelId = table.Column<int>(type: "int", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_AspNetUsers_CareerPhase_CareerPhaseId",
                        column: x => x.CareerPhaseId,
                        principalTable: "CareerPhase",
                        principalColumn: "CareerPhaseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_ExperienceLevel_ExperienceLevelId",
                        column: x => x.ExperienceLevelId,
                        principalTable: "ExperienceLevel",
                        principalColumn: "ExperienceLevelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "GenderId",
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

            migrationBuilder.CreateTable(
                name: "HobbyUser",
                columns: table => new
                {
                    SlackId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HobbyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HobbyUser", x => new { x.SlackId, x.HobbyId });
                    table.ForeignKey(
                        name: "FK_HobbyUser_AspNetUsers_SlackId",
                        column: x => x.SlackId,
                        principalTable: "AspNetUsers",
                        principalColumn: "SlackId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HobbyUser_Hobby_HobbyId",
                        column: x => x.HobbyId,
                        principalTable: "Hobby",
                        principalColumn: "HobbyId",
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
                table: "CareerPhase",
                columns: new[] { "CareerPhaseId", "Name" },
                values: new object[,]
                {
                    { 1, "Starter" },
                    { 2, "Changer" },
                    { 3, "Developer" }
                });

            migrationBuilder.InsertData(
                table: "ExperienceLevel",
                columns: new[] { "ExperienceLevelId", "Name" },
                values: new object[,]
                {
                    { 1, "Beginner" },
                    { 2, "Novice" },
                    { 3, "Intermediate" },
                    { 4, "Advanced" },
                    { 5, "Expert" }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "GenderId", "Name" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" },
                    { 3, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Hobby",
                columns: new[] { "HobbyId", "Name" },
                values: new object[,]
                {
                    { 1, "Acting" },
                    { 2, "Adventure_Sports" },
                    { 3, "Anime" },
                    { 4, "Archery" },
                    { 5, "Art" },
                    { 6, "Astrology" },
                    { 7, "Astronomy" },
                    { 8, "Baseball" },
                    { 9, "Basketball" },
                    { 10, "Biking" },
                    { 11, "Blogging" },
                    { 12, "Board_Games" },
                    { 13, "Card_Games" },
                    { 14, "Cars" },
                    { 15, "Chess" },
                    { 16, "Cinema" },
                    { 17, "Classical_Music" },
                    { 18, "Comics" },
                    { 19, "Concerts" },
                    { 20, "Cooking" },
                    { 21, "Cosplaying" },
                    { 22, "Crafts" },
                    { 23, "Creative_Writing" },
                    { 24, "Cycling" },
                    { 25, "Digital_Art" },
                    { 26, "DIY" },
                    { 27, "DJing" },
                    { 28, "Drawing" },
                    { 29, "Economics" },
                    { 30, "Electronic_Music" },
                    { 31, "Entrepreneurship" },
                    { 32, "Fashion" },
                    { 33, "Fiction" },
                    { 34, "Filmmaking" },
                    { 35, "Fitness" },
                    { 36, "Folk_Music" },
                    { 37, "Football" },
                    { 38, "Golf" },
                    { 39, "Handball" },
                    { 40, "Hiking" },
                    { 41, "History" },
                    { 42, "Hockey" },
                    { 43, "Horseback_Riding" },
                    { 44, "Jazz" },
                    { 45, "Learning_Languages" },
                    { 46, "Mathematics" },
                    { 47, "Martial_Arts" },
                    { 48, "Metal" },
                    { 49, "Music" },
                    { 50, "Musicals" },
                    { 51, "Music_Production" },
                    { 52, "Non_Fiction" },
                    { 53, "Opera" },
                    { 54, "Painting" },
                    { 55, "Pets" },
                    { 56, "Philosophy" },
                    { 57, "Photography" },
                    { 58, "Playing_An_Instrument" },
                    { 59, "Politics" },
                    { 60, "Pop_Music" },
                    { 61, "Reading" },
                    { 62, "Restaurants" },
                    { 63, "Rock_Music" },
                    { 64, "Rugby" },
                    { 65, "Running" },
                    { 66, "Sailing" },
                    { 67, "Sculpting" },
                    { 68, "Sewing" },
                    { 69, "Shopping" },
                    { 70, "Skiing" },
                    { 71, "Snow_Sports" },
                    { 72, "Street_Art" },
                    { 73, "Swimming" },
                    { 74, "Tennis" },
                    { 75, "Theatre" },
                    { 76, "Travel" },
                    { 77, "Video_Games" },
                    { 78, "Volunteering" },
                    { 79, "Walking" },
                    { 80, "Water_Sports" },
                    { 81, "Yoga" }
                });

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
                table: "AspNetUsers",
                columns: new[] { "SlackId", "AccessFailedCount", "Bio", "CareerPhaseId", "ConcurrencyStamp", "Email", "EmailConfirmed", "ExperienceLevelId", "GenderId", "Id", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "U73VQP71", 0, "Hello, my name is John. I am interested in AI.", 2, "d99ba0bb-fa8e-49ae-a9c1-0ba048f8bc28", null, false, 2, 1, "5f9d7795-482c-4bfb-b58b-2119a006f912", false, null, null, null, null, null, false, "4e2f64cb-18f5-49d4-8ccd-cb5426fb252d", false, null });

            migrationBuilder.InsertData(
                table: "CSInterestUser",
                columns: new[] { "CSInterestId", "SlackId" },
                values: new object[,]
                {
                    { 1, "U73VQP71" },
                    { 2, "U73VQP71" },
                    { 3, "U73VQP71" }
                });

            migrationBuilder.InsertData(
                table: "HobbyUser",
                columns: new[] { "HobbyId", "SlackId" },
                values: new object[,]
                {
                    { 10, "U73VQP71" },
                    { 21, "U73VQP71" },
                    { 43, "U73VQP71" }
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
                name: "IX_AspNetUsers_CareerPhaseId",
                table: "AspNetUsers",
                column: "CareerPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ExperienceLevelId",
                table: "AspNetUsers",
                column: "ExperienceLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GenderId",
                table: "AspNetUsers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CSInterestUser_CSInterestId",
                table: "CSInterestUser",
                column: "CSInterestId");

            migrationBuilder.CreateIndex(
                name: "IX_HobbyUser_HobbyId",
                table: "HobbyUser",
                column: "HobbyId");

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
                name: "CSInterestUser");

            migrationBuilder.DropTable(
                name: "HobbyUser");

            migrationBuilder.DropTable(
                name: "NaturalLanguageUser");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguageUser");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CSInterest");

            migrationBuilder.DropTable(
                name: "Hobby");

            migrationBuilder.DropTable(
                name: "NaturalLanguages");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguages");

            migrationBuilder.DropTable(
                name: "CareerPhase");

            migrationBuilder.DropTable(
                name: "ExperienceLevel");

            migrationBuilder.DropTable(
                name: "Gender");
        }
    }
}
