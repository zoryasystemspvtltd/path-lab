using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PathlabApi.Migrations
{
    /// <inheritdoc />
    public partial class pathlabapiinitialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dependencies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitOfWorks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<long>(type: "bigint", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MarkerJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    ParentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanId = table.Column<long>(type: "bigint", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitOfWorks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ApplicationLogs",
                columns: new[] { "Id", "ActivityType", "ContentHistory", "Date", "EntityId", "Key", "Member", "Name", "Status" },
                values: new object[,]
                {
                    { 1L, 0, null, new DateTime(2025, 3, 31, 6, 14, 50, 473, DateTimeKind.Utc).AddTicks(7496), 1L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "super@rajwada.com", "Company", 0 },
                    { 2L, 0, null, new DateTime(2025, 3, 31, 6, 14, 50, 473, DateTimeKind.Utc).AddTicks(7499), 1L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "super@rajwada.com", "Department", 0 },
                    { 3L, 0, null, new DateTime(2025, 3, 31, 6, 14, 50, 473, DateTimeKind.Utc).AddTicks(7501), 2L, "1536B022-C5C9-4358-BB6A-466F2075B7D4", "super@rajwada.com", "Department", 0 }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Code", "Date", "Key", "Member", "Name", "Status" },
                values: new object[,]
                {
                    { 1L, "CI", new DateTime(2025, 3, 31, 6, 14, 50, 473, DateTimeKind.Utc).AddTicks(7449), "1536B022-C5C9-4358-BB6A-466F2075B7D4", "super@rajwada.com", "Civil", 0 },
                    { 2L, "LE", new DateTime(2025, 3, 31, 6, 14, 50, 473, DateTimeKind.Utc).AddTicks(7452), "1536B022-C5C9-4358-BB6A-466F2075B7D4", "super@rajwada.com", "Legal", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnitOfWorks_ActivityId",
                table: "UnitOfWorks",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitOfWorks_ParentId",
                table: "UnitOfWorks",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitOfWorks_PlanId",
                table: "UnitOfWorks",
                column: "PlanId");
        }
    }
}
