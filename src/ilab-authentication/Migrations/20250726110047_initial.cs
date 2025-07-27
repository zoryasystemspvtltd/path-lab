using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IlabAuthentication.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Disable = table.Column<bool>(type: "bit", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Theme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetUsers_ParentId",
                        column: x => x.ParentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
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
                name: "Privileges",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Module = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RoleId = table.Column<long>(type: "bigint", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privileges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Privileges_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Key", "Member", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1L, "1fbd204a-762b-4149-9a54-44ae6354d79c", "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "root", "ROOT" },
                    { 2L, "26E9A03B-E6BB-4567-A36B-E1DE6B6C1227", "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "Super Admin", "SUPER" },
                    { 3L, "d3dff883-d8ba-4f25-8529-29ef5f5343ce", "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "Admin", "ADMIN" },
                    { 4L, "c78c489a-fb53-4a42-aee6-60818a3be800", "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Department", "Disable", "Email", "EmailConfirmed", "FirstName", "Key", "LastName", "LockoutEnabled", "LockoutEnd", "Member", "NormalizedEmail", "NormalizedUserName", "ParentId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoUrl", "SecurityStamp", "Theme", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1L, 0, null, "a7e26408-644a-48ca-a0a7-7cb94e41315d", null, false, "root", true, "Root", "1536B022-C5C9-4358-BB6A-466F2075B7D4", "", false, null, "root", "ROOT", "ROOT", null, "AQAAAAIAAYagAAAAELjslJJId5s/CZUdXozgD3Pr7IbgTUn+CiLkN8o1sf2+WTJWizU2wDKXb/IPyW35/Q==", "0000", false, null, "3DMLAIZXSOSRUJWEQ2R7NTE7NGAAQYBA", null, false, "root" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1L, 1L });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Department", "Disable", "Email", "EmailConfirmed", "FirstName", "Key", "LastName", "LockoutEnabled", "LockoutEnd", "Member", "NormalizedEmail", "NormalizedUserName", "ParentId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoUrl", "SecurityStamp", "Theme", "TwoFactorEnabled", "UserName" },
                values: new object[] { 2L, 0, null, "e6ac56cd-cb41-4059-b979-a0d7a7ac5fe0", null, false, "super@zorya.co.in", true, "Super", "1536B022-C5C9-4358-BB6A-466F2075B7D4", "Admin", false, null, "root", "SUPER@ZORYA.CO.IN", "SUPER", 1L, "AQAAAAIAAYagAAAAELjslJJId5s/CZUdXozgD3Pr7IbgTUn+CiLkN8o1sf2+WTJWizU2wDKXb/IPyW35/Q==", "0000", false, null, "3DMLAIZXSOSRUJWEQ2R7NTE7NGAAQYBA", null, false, "super@zorya.co.in" });

            migrationBuilder.InsertData(
                table: "Privileges",
                columns: new[] { "Id", "Key", "Member", "Module", "Name", "RoleId", "Type" },
                values: new object[,]
                {
                    { 1L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "user", "add", 1L, null },
                    { 2L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "user", "edit", 1L, null },
                    { 3L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "user", "delete", 1L, null },
                    { 4L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "user", "view", 1L, null },
                    { 5L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "user", "list", 1L, null },
                    { 6L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "role", "add", 1L, null },
                    { 7L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "role", "edit", 1L, null },
                    { 8L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "role", "delete", 1L, null },
                    { 9L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "role", "view", 1L, null },
                    { 10L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "role", "list", 1L, null },
                    { 11L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "user", "add", 2L, null },
                    { 12L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "user", "edit", 2L, null },
                    { 13L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "user", "delete", 2L, null },
                    { 14L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "user", "view", 2L, null },
                    { 15L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "user", "list", 2L, null },
                    { 16L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "role", "add", 2L, null },
                    { 17L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "role", "edit", 2L, null },
                    { 18L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "role", "delete", 2L, null },
                    { 19L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "role", "view", 2L, null },
                    { 20L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "role", "list", 2L, null },
                    { 21L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "enterprise", "add", 2L, null },
                    { 22L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "enterprise", "edit", 2L, null },
                    { 23L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "enterprise", "delete", 2L, null },
                    { 24L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "enterprise", "view", 2L, null },
                    { 25L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "enterprise", "list", 2L, null },
                    { 26L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "businessunit", "add", 2L, null },
                    { 27L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "businessunit", "edit", 2L, null },
                    { 28L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "businessunit", "delete", 2L, null },
                    { 29L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "businessunit", "view", 2L, null },
                    { 30L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "businessunit", "list", 2L, null },
                    { 31L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "vendor", "add", 2L, null },
                    { 32L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "vendor", "edit", 2L, null },
                    { 33L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "vendor", "delete", 2L, null },
                    { 34L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "vendor", "view", 2L, null },
                    { 35L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "vendor", "list", 2L, null },
                    { 36L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "purchaseorder", "add", 2L, null },
                    { 37L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "purchaseorder", "edit", 2L, null },
                    { 38L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "purchaseorder", "delete", 2L, null },
                    { 39L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "purchaseorder", "view", 2L, null },
                    { 40L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "purchaseorder", "list", 2L, null },
                    { 41L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "purchaseorderitem", "add", 2L, null },
                    { 42L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "purchaseorderitem", "edit", 2L, null },
                    { 43L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "purchaseorderitem", "delete", 2L, null },
                    { 44L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "purchaseorderitem", "view", 2L, null },
                    { 45L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "purchaseorderitem", "list", 2L, null },
                    { 46L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "grn", "add", 2L, null },
                    { 47L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "grn", "edit", 2L, null },
                    { 48L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "grn", "delete", 2L, null },
                    { 49L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "grn", "view", 2L, null },
                    { 50L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "grn", "list", 2L, null },
                    { 51L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "grnitem", "add", 2L, null },
                    { 52L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "grnitem", "edit", 2L, null },
                    { 53L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "grnitem", "delete", 2L, null },
                    { 54L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "grnitem", "view", 2L, null },
                    { 55L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "grnitem", "list", 2L, null },
                    { 56L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "indent", "add", 2L, null },
                    { 57L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "indent", "edit", 2L, null },
                    { 58L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "indent", "delete", 2L, null },
                    { 59L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "indent", "view", 2L, null },
                    { 60L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "indent", "list", 2L, null },
                    { 61L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "indentitem", "add", 2L, null },
                    { 62L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "indentitem", "edit", 2L, null },
                    { 63L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "indentitem", "delete", 2L, null },
                    { 64L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "indentitem", "view", 2L, null },
                    { 65L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "indentitem", "list", 2L, null },
                    { 66L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "itemmaster", "add", 2L, null },
                    { 67L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "itemmaster", "edit", 2L, null },
                    { 68L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "itemmaster", "delete", 2L, null },
                    { 69L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "itemmaster", "view", 2L, null },
                    { 70L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "itemmaster", "list", 2L, null },
                    { 71L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "store", "add", 2L, null },
                    { 72L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "store", "edit", 2L, null },
                    { 73L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "store", "delete", 2L, null },
                    { 74L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "store", "view", 2L, null },
                    { 75L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "store", "list", 2L, null },
                    { 76L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "stockentry", "add", 2L, null },
                    { 77L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "stockentry", "edit", 2L, null },
                    { 78L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "stockentry", "delete", 2L, null },
                    { 79L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "stockentry", "view", 2L, null },
                    { 80L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "stockentry", "list", 2L, null },
                    { 81L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "stockconsumption", "add", 2L, null },
                    { 82L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "stockconsumption", "edit", 2L, null },
                    { 83L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "stockconsumption", "delete", 2L, null },
                    { 84L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "stockconsumption", "view", 2L, null },
                    { 85L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "stockconsumption", "list", 2L, null },
                    { 86L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "stockadjustment", "add", 2L, null },
                    { 87L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "stockadjustment", "edit", 2L, null },
                    { 88L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "stockadjustment", "delete", 2L, null },
                    { 89L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "stockadjustment", "view", 2L, null },
                    { 90L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "stockadjustment", "list", 2L, null },
                    { 91L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "category", "add", 2L, null },
                    { 92L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "category", "edit", 2L, null },
                    { 93L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "category", "delete", 2L, null },
                    { 94L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "category", "view", 2L, null },
                    { 95L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "category", "list", 2L, null },
                    { 96L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "unitofmeasure", "add", 2L, null },
                    { 97L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "unitofmeasure", "edit", 2L, null },
                    { 98L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "unitofmeasure", "delete", 2L, null },
                    { 99L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "unitofmeasure", "view", 2L, null },
                    { 100L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "unitofmeasure", "list", 2L, null },
                    { 101L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "testmaster", "add", 2L, null },
                    { 102L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "testmaster", "edit", 2L, null },
                    { 103L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "testmaster", "delete", 2L, null },
                    { 104L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "testmaster", "view", 2L, null },
                    { 105L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "testmaster", "list", 2L, null },
                    { 106L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "testparameter", "add", 2L, null },
                    { 107L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "testparameter", "edit", 2L, null },
                    { 108L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "testparameter", "delete", 2L, null },
                    { 109L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "testparameter", "view", 2L, null },
                    { 110L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "testparameter", "list", 2L, null },
                    { 111L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "specimenmaster", "add", 2L, null },
                    { 112L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "specimenmaster", "edit", 2L, null },
                    { 113L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "specimenmaster", "delete", 2L, null },
                    { 114L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "specimenmaster", "view", 2L, null },
                    { 115L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "specimenmaster", "list", 2L, null },
                    { 116L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "department", "add", 2L, null },
                    { 117L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "department", "edit", 2L, null },
                    { 118L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "department", "delete", 2L, null },
                    { 119L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "department", "view", 2L, null },
                    { 120L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "department", "list", 2L, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 2L, 2L });

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
                name: "IX_AspNetUsers_ParentId",
                table: "AspNetUsers",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Privileges_RoleId",
                table: "Privileges",
                column: "RoleId");
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
                name: "Privileges");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");
        }
    }
}
