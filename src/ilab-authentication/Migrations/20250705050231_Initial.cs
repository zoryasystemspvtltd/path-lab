﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IlabAuthentication.Migrations
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
                values: new object[] { 1L, 0, null, "a7e26408-644a-48ca-a0a7-7cb94e41315d", null, false, "root", true, "Root", "1536B022-C5C9-4358-BB6A-466F2075B7D4", "", false, null, "root", "ROOT", "ROOT", null, "AQAAAAIAAYagAAAAEIUXHqy53Dre8nfwKZJ/mfDjLdtvMcpPO0pC7M4VwCb+K+eta6c8nxYOp21EfUbGzg==", "0000", false, null, "R7JOVNY6TU5ACLDKWMJCCXJZIHNATIIJ", null, false, "root" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1L, 1L });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Department", "Disable", "Email", "EmailConfirmed", "FirstName", "Key", "LastName", "LockoutEnabled", "LockoutEnd", "Member", "NormalizedEmail", "NormalizedUserName", "ParentId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoUrl", "SecurityStamp", "Theme", "TwoFactorEnabled", "UserName" },
                values: new object[] { 2L, 0, null, "e6ac56cd-cb41-4059-b979-a0d7a7ac5fe0", null, false, "super@zorya.co.in", true, "Super", "1536B022-C5C9-4358-BB6A-466F2075B7D4", "Admin", false, null, "root", "SUPER@ZORYA.CO.IN", "SUPER", 1L, "AQAAAAIAAYagAAAAEAvvhBeNuMBXOP4HueTG/lZiPS1ieIlXzH5CWQCcpPu1ouRK53hHwO7cuWDJg8oBzw==", "0000", false, null, "P2GVVVE7O7TUFSSULMZN4QT4MPTC6YHT", null, false, "super@zorya.co.in" });

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
                    { 21L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "company", "add", 2L, null },
                    { 22L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "company", "edit", 2L, null },
                    { 23L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "company", "delete", 2L, null },
                    { 24L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "company", "view", 2L, null },
                    { 25L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "company", "list", 2L, null },
                    { 26L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "project", "add", 2L, null },
                    { 27L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "project", "edit", 2L, null },
                    { 28L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "project", "delete", 2L, null },
                    { 29L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "project", "view", 2L, null },
                    { 30L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "project", "list", 2L, null },
                    { 31L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "root", "department", "list", 2L, null }
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
