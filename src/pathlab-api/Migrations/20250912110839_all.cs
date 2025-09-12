using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PathlabApi.Migrations
{
    /// <inheritdoc />
    public partial class all : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GRNItems_ItemMasters_ItemMasterId",
                table: "GRNItems");

            migrationBuilder.DropForeignKey(
                name: "FK_IndentItems_ItemMasters_ItemMasterId",
                table: "IndentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItems_ItemMasters_ItemMasterId",
                table: "PurchaseOrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrders_Vendors_VendorId",
                table: "PurchaseOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ReagentMappings_ItemMasters_ItemMasterId",
                table: "ReagentMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_StockAdjustments_ItemMasters_ItemMasterId",
                table: "StockAdjustments");

            migrationBuilder.DropForeignKey(
                name: "FK_StockConsumptions_ItemMasters_ItemMasterId",
                table: "StockConsumptions");

            migrationBuilder.DropForeignKey(
                name: "FK_StockEntries_ItemMasters_ItemMasterId",
                table: "StockEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_TestMasters_SpecimenMasters_SpecimenMasterId",
                table: "TestMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_TestMasters_TestMasters_TestMasterId",
                table: "TestMasters");

            migrationBuilder.DropTable(
                name: "TestParameters");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_TestMasters_SpecimenMasterId",
                table: "TestMasters");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "ItemMasters");

            migrationBuilder.RenameColumn(
                name: "TestMasterId",
                table: "TestMasters",
                newName: "SpecimenId");

            migrationBuilder.RenameColumn(
                name: "SpecimenMasterId",
                table: "TestMasters",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_TestMasters_TestMasterId",
                table: "TestMasters",
                newName: "IX_TestMasters_SpecimenId");

            migrationBuilder.RenameColumn(
                name: "ItemMasterId",
                table: "StockEntries",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_StockEntries_ItemMasterId",
                table: "StockEntries",
                newName: "IX_StockEntries_ItemId");

            migrationBuilder.RenameColumn(
                name: "ItemMasterId",
                table: "StockConsumptions",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_StockConsumptions_ItemMasterId",
                table: "StockConsumptions",
                newName: "IX_StockConsumptions_ItemId");

            migrationBuilder.RenameColumn(
                name: "ItemMasterId",
                table: "StockAdjustments",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_StockAdjustments_ItemMasterId",
                table: "StockAdjustments",
                newName: "IX_StockAdjustments_ItemId");

            migrationBuilder.RenameColumn(
                name: "ItemMasterId",
                table: "ReagentMappings",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ReagentMappings_ItemMasterId",
                table: "ReagentMappings",
                newName: "IX_ReagentMappings_ItemId");

            migrationBuilder.RenameColumn(
                name: "VendorId",
                table: "PurchaseOrders",
                newName: "SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrders_VendorId",
                table: "PurchaseOrders",
                newName: "IX_PurchaseOrders_SupplierId");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "PurchaseOrderItems",
                newName: "Rate");

            migrationBuilder.RenameColumn(
                name: "ItemMasterId",
                table: "PurchaseOrderItems",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrderItems_ItemMasterId",
                table: "PurchaseOrderItems",
                newName: "IX_PurchaseOrderItems_ItemId");

            migrationBuilder.RenameColumn(
                name: "ItemMasterId",
                table: "IndentItems",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_IndentItems_ItemMasterId",
                table: "IndentItems",
                newName: "IX_IndentItems_ItemId");

            migrationBuilder.RenameColumn(
                name: "ItemMasterId",
                table: "GRNItems",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_GRNItems_ItemMasterId",
                table: "GRNItems",
                newName: "IX_GRNItems_ItemId");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TestMasters",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CompanyId",
                table: "TestMasters",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TestMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BusinessUnitId",
                table: "SpecimenMasters",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SpecimenMasters",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApprovalStatus",
                table: "PurchaseOrders",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CompanyId",
                table: "PurchaseOrders",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FinancialYearId",
                table: "PurchaseOrders",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "IndentId",
                table: "PurchaseOrderItems",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Centralized",
                table: "ItemMasters",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ItemGroupId",
                table: "ItemMasters",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ItemTypeId",
                table: "ItemMasters",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Rate",
                table: "ItemMasters",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FinancialYearId",
                table: "Indents",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Purpose",
                table: "Indents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "RequiredByDate",
                table: "Indents",
                type: "date",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "IndentItems",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FinancialYearId",
                table: "GRNs",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PerformedBy",
                table: "GRNs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReceivedDate",
                table: "GRNs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Enterprises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Enterprises",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Enterprises",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Departments",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "BusinessUnits",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CompanyId",
                table: "BusinessUnits",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BusinessUnits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AccountGroups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParentGroupId = table.Column<long>(type: "bigint", nullable: true),
                    HierarchyLevel = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnterpriseId = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Enterprises_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "Enterprises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ControlResults",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ResultDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EquipmentId = table.Column<int>(type: "int", nullable: true),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentHeartBeats",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsAlive = table.Column<bool>(type: "bit", nullable: false),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentHeartBeats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentMasters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AccessKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentMasters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinancialYears",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialYears", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HisPatientId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferralDoctorMasters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HospitalAffiliation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferralDoctorMasters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SampleCollectorMasters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsInternal = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleCollectorMasters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    QuantityAvailable = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockStatus_ItemMasters_ItemId",
                        column: x => x.ItemId,
                        principalTable: "ItemMasters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TestReagentMasters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<long>(type: "bigint", nullable: true),
                    BatchNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExpiryDate = table.Column<DateOnly>(type: "date", nullable: false),
                    QuantityAvailable = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitOfMeasure = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestReagentMasters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ledgers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountGroupId = table.Column<long>(type: "bigint", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: true),
                    LedgerType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ledgers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ledgers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GSTIN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PAN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Supplier_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ControlResultDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlResultId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    LISParamCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LISParamValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LISParamUnit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlResultDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlResultDetails_ControlResults_ControlResultId",
                        column: x => x.ControlResultId,
                        principalTable: "ControlResults",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TestMappingMasters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SpecimenCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LISTestCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LISTestCodeDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GroupName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EquipmentId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestMappingMasters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestMappingMasters_EquipmentMasters_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "EquipmentMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemGroups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemTypeId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemGroups_ItemType_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TestRequestDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TestCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TestName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SampleCollectionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SampleReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SpecimenCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SpecimenName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReportStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IPNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BedNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MRNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    HISRequestId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    HISRequestNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestRequestDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestRequestDetails_PatientDetails_PatientId",
                        column: x => x.PatientId,
                        principalTable: "PatientDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestResults",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TestCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LISTestCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SpecimenCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ResultDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SampleCollectionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SampleReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuthorizationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AuthorizedBy = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReviewedBy = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TechnicianNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    TestRequestId = table.Column<long>(type: "bigint", nullable: false),
                    EquipmentId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestResults_EquipmentMasters_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "EquipmentMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestResults_PatientDetails_PatientId",
                        column: x => x.PatientId,
                        principalTable: "PatientDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReferralDoctorFeeSetups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    ReferralDoctorId = table.Column<long>(type: "bigint", nullable: true),
                    TestId = table.Column<long>(type: "bigint", nullable: true),
                    FeeType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FeeValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EffectiveFrom = table.Column<DateOnly>(type: "date", nullable: false),
                    EffectiveTo = table.Column<DateOnly>(type: "date", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferralDoctorFeeSetups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReferralDoctorFeeSetups_ReferralDoctorMasters_ReferralDoctorId",
                        column: x => x.ReferralDoctorId,
                        principalTable: "ReferralDoctorMasters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReferralDoctorFeeSetups_TestMasters_TestId",
                        column: x => x.TestId,
                        principalTable: "TestMasters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SampleCollectorFeeSetups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    CollectorId = table.Column<long>(type: "bigint", nullable: true),
                    TestId = table.Column<long>(type: "bigint", nullable: true),
                    FeeType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FeeValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EffectiveFrom = table.Column<DateOnly>(type: "date", nullable: false),
                    EffectiveTo = table.Column<DateOnly>(type: "date", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleCollectorFeeSetups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleCollectorFeeSetups_SampleCollectorMasters_CollectorId",
                        column: x => x.CollectorId,
                        principalTable: "SampleCollectorMasters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SampleCollectorFeeSetups_TestMasters_TestId",
                        column: x => x.TestId,
                        principalTable: "TestMasters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TestReagentMapping",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<long>(type: "bigint", nullable: true),
                    TestId = table.Column<long>(type: "bigint", nullable: true),
                    ReagentId = table.Column<long>(type: "bigint", nullable: true),
                    QuantityRequired = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitOfMeasure = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestReagentMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestReagentMapping_TestMasters_TestId",
                        column: x => x.TestId,
                        principalTable: "TestMasters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TestReagentMapping_TestReagentMasters_ReagentId",
                        column: x => x.ReagentId,
                        principalTable: "TestReagentMasters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseBills",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierId = table.Column<long>(type: "bigint", nullable: true),
                    FinancialYearId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseBills_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ParameterMaster",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LISParamCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParamUnit = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ParamMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TestId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    TestMappingMasterId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterMaster", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParameterMaster_TestMappingMasters_TestMappingMasterId",
                        column: x => x.TestMappingMasterId,
                        principalTable: "TestMappingMasters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ParameterMaster_TestMasters_TestId",
                        column: x => x.TestId,
                        principalTable: "TestMasters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TestRequestParameters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TestCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TestRequestDetailsId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestRequestParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestRequestParameters_TestRequestDetails_TestRequestDetailsId",
                        column: x => x.TestRequestDetailsId,
                        principalTable: "TestRequestDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestResultDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LISParamCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LISParamValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LISParamUnit = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TestResultId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestResultDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestResultDetails_TestResults_TestResultId",
                        column: x => x.TestResultId,
                        principalTable: "TestResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParameterRangMasters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Value = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AgeFrom = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AgeTo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AgeType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MinValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ParameterId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterRangMasters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParameterRangMasters_ParameterMaster_ParameterId",
                        column: x => x.ParameterId,
                        principalTable: "ParameterMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_CompanyId",
                table: "PurchaseOrders",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMasters_ItemGroupId",
                table: "ItemMasters",
                column: "ItemGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMasters_ItemTypeId",
                table: "ItemMasters",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnits_CompanyId",
                table: "BusinessUnits",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_EnterpriseId",
                table: "Companies",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlResultDetails_ControlResultId",
                table: "ControlResultDetails",
                column: "ControlResultId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemGroups_ItemTypeId",
                table: "ItemGroups",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ledgers_CompanyId",
                table: "Ledgers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterMaster_TestId",
                table: "ParameterMaster",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterMaster_TestMappingMasterId",
                table: "ParameterMaster",
                column: "TestMappingMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterRangMasters_ParameterId",
                table: "ParameterRangMasters",
                column: "ParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseBills_SupplierId",
                table: "PurchaseBills",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferralDoctorFeeSetups_ReferralDoctorId",
                table: "ReferralDoctorFeeSetups",
                column: "ReferralDoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferralDoctorFeeSetups_TestId",
                table: "ReferralDoctorFeeSetups",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleCollectorFeeSetups_CollectorId",
                table: "SampleCollectorFeeSetups",
                column: "CollectorId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleCollectorFeeSetups_TestId",
                table: "SampleCollectorFeeSetups",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_StockStatus_ItemId",
                table: "StockStatus",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_CompanyId",
                table: "Supplier",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_TestMappingMasters_EquipmentId",
                table: "TestMappingMasters",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TestReagentMapping_ReagentId",
                table: "TestReagentMapping",
                column: "ReagentId");

            migrationBuilder.CreateIndex(
                name: "IX_TestReagentMapping_TestId",
                table: "TestReagentMapping",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_TestRequestDetails_PatientId",
                table: "TestRequestDetails",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_TestRequestParameters_TestRequestDetailsId",
                table: "TestRequestParameters",
                column: "TestRequestDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_TestResultDetails_TestResultId",
                table: "TestResultDetails",
                column: "TestResultId");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_EquipmentId",
                table: "TestResults",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_PatientId",
                table: "TestResults",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessUnits_Companies_CompanyId",
                table: "BusinessUnits",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GRNItems_ItemMasters_ItemId",
                table: "GRNItems",
                column: "ItemId",
                principalTable: "ItemMasters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IndentItems_ItemMasters_ItemId",
                table: "IndentItems",
                column: "ItemId",
                principalTable: "ItemMasters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemMasters_ItemGroups_ItemGroupId",
                table: "ItemMasters",
                column: "ItemGroupId",
                principalTable: "ItemGroups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemMasters_ItemType_ItemTypeId",
                table: "ItemMasters",
                column: "ItemTypeId",
                principalTable: "ItemType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItems_ItemMasters_ItemId",
                table: "PurchaseOrderItems",
                column: "ItemId",
                principalTable: "ItemMasters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrders_Companies_CompanyId",
                table: "PurchaseOrders",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrders_Supplier_SupplierId",
                table: "PurchaseOrders",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReagentMappings_ItemMasters_ItemId",
                table: "ReagentMappings",
                column: "ItemId",
                principalTable: "ItemMasters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockAdjustments_ItemMasters_ItemId",
                table: "StockAdjustments",
                column: "ItemId",
                principalTable: "ItemMasters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockConsumptions_ItemMasters_ItemId",
                table: "StockConsumptions",
                column: "ItemId",
                principalTable: "ItemMasters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockEntries_ItemMasters_ItemId",
                table: "StockEntries",
                column: "ItemId",
                principalTable: "ItemMasters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TestMasters_SpecimenMasters_SpecimenId",
                table: "TestMasters",
                column: "SpecimenId",
                principalTable: "SpecimenMasters",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessUnits_Companies_CompanyId",
                table: "BusinessUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_GRNItems_ItemMasters_ItemId",
                table: "GRNItems");

            migrationBuilder.DropForeignKey(
                name: "FK_IndentItems_ItemMasters_ItemId",
                table: "IndentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemMasters_ItemGroups_ItemGroupId",
                table: "ItemMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemMasters_ItemType_ItemTypeId",
                table: "ItemMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItems_ItemMasters_ItemId",
                table: "PurchaseOrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrders_Companies_CompanyId",
                table: "PurchaseOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrders_Supplier_SupplierId",
                table: "PurchaseOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ReagentMappings_ItemMasters_ItemId",
                table: "ReagentMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_StockAdjustments_ItemMasters_ItemId",
                table: "StockAdjustments");

            migrationBuilder.DropForeignKey(
                name: "FK_StockConsumptions_ItemMasters_ItemId",
                table: "StockConsumptions");

            migrationBuilder.DropForeignKey(
                name: "FK_StockEntries_ItemMasters_ItemId",
                table: "StockEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_TestMasters_SpecimenMasters_SpecimenId",
                table: "TestMasters");

            migrationBuilder.DropTable(
                name: "AccountGroups");

            migrationBuilder.DropTable(
                name: "ControlResultDetails");

            migrationBuilder.DropTable(
                name: "EquipmentHeartBeats");

            migrationBuilder.DropTable(
                name: "FinancialYears");

            migrationBuilder.DropTable(
                name: "ItemGroups");

            migrationBuilder.DropTable(
                name: "Ledgers");

            migrationBuilder.DropTable(
                name: "ParameterRangMasters");

            migrationBuilder.DropTable(
                name: "PurchaseBills");

            migrationBuilder.DropTable(
                name: "ReferralDoctorFeeSetups");

            migrationBuilder.DropTable(
                name: "SampleCollectorFeeSetups");

            migrationBuilder.DropTable(
                name: "StockStatus");

            migrationBuilder.DropTable(
                name: "TestReagentMapping");

            migrationBuilder.DropTable(
                name: "TestRequestParameters");

            migrationBuilder.DropTable(
                name: "TestResultDetails");

            migrationBuilder.DropTable(
                name: "ControlResults");

            migrationBuilder.DropTable(
                name: "ItemType");

            migrationBuilder.DropTable(
                name: "ParameterMaster");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "ReferralDoctorMasters");

            migrationBuilder.DropTable(
                name: "SampleCollectorMasters");

            migrationBuilder.DropTable(
                name: "TestReagentMasters");

            migrationBuilder.DropTable(
                name: "TestRequestDetails");

            migrationBuilder.DropTable(
                name: "TestResults");

            migrationBuilder.DropTable(
                name: "TestMappingMasters");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "PatientDetails");

            migrationBuilder.DropTable(
                name: "EquipmentMasters");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrders_CompanyId",
                table: "PurchaseOrders");

            migrationBuilder.DropIndex(
                name: "IX_ItemMasters_ItemGroupId",
                table: "ItemMasters");

            migrationBuilder.DropIndex(
                name: "IX_ItemMasters_ItemTypeId",
                table: "ItemMasters");

            migrationBuilder.DropIndex(
                name: "IX_BusinessUnits_CompanyId",
                table: "BusinessUnits");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TestMasters");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "TestMasters");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TestMasters");

            migrationBuilder.DropColumn(
                name: "BusinessUnitId",
                table: "SpecimenMasters");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SpecimenMasters");

            migrationBuilder.DropColumn(
                name: "ApprovalStatus",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "FinancialYearId",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "IndentId",
                table: "PurchaseOrderItems");

            migrationBuilder.DropColumn(
                name: "Centralized",
                table: "ItemMasters");

            migrationBuilder.DropColumn(
                name: "ItemGroupId",
                table: "ItemMasters");

            migrationBuilder.DropColumn(
                name: "ItemTypeId",
                table: "ItemMasters");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "ItemMasters");

            migrationBuilder.DropColumn(
                name: "FinancialYearId",
                table: "Indents");

            migrationBuilder.DropColumn(
                name: "Purpose",
                table: "Indents");

            migrationBuilder.DropColumn(
                name: "RequiredByDate",
                table: "Indents");

            migrationBuilder.DropColumn(
                name: "FinancialYearId",
                table: "GRNs");

            migrationBuilder.DropColumn(
                name: "PerformedBy",
                table: "GRNs");

            migrationBuilder.DropColumn(
                name: "ReceivedDate",
                table: "GRNs");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Enterprises");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Enterprises");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Enterprises");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "BusinessUnits");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "BusinessUnits");

            migrationBuilder.RenameColumn(
                name: "SpecimenId",
                table: "TestMasters",
                newName: "TestMasterId");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "TestMasters",
                newName: "SpecimenMasterId");

            migrationBuilder.RenameIndex(
                name: "IX_TestMasters_SpecimenId",
                table: "TestMasters",
                newName: "IX_TestMasters_TestMasterId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "StockEntries",
                newName: "ItemMasterId");

            migrationBuilder.RenameIndex(
                name: "IX_StockEntries_ItemId",
                table: "StockEntries",
                newName: "IX_StockEntries_ItemMasterId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "StockConsumptions",
                newName: "ItemMasterId");

            migrationBuilder.RenameIndex(
                name: "IX_StockConsumptions_ItemId",
                table: "StockConsumptions",
                newName: "IX_StockConsumptions_ItemMasterId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "StockAdjustments",
                newName: "ItemMasterId");

            migrationBuilder.RenameIndex(
                name: "IX_StockAdjustments_ItemId",
                table: "StockAdjustments",
                newName: "IX_StockAdjustments_ItemMasterId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "ReagentMappings",
                newName: "ItemMasterId");

            migrationBuilder.RenameIndex(
                name: "IX_ReagentMappings_ItemId",
                table: "ReagentMappings",
                newName: "IX_ReagentMappings_ItemMasterId");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "PurchaseOrders",
                newName: "VendorId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrders_SupplierId",
                table: "PurchaseOrders",
                newName: "IX_PurchaseOrders_VendorId");

            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "PurchaseOrderItems",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "PurchaseOrderItems",
                newName: "ItemMasterId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrderItems_ItemId",
                table: "PurchaseOrderItems",
                newName: "IX_PurchaseOrderItems_ItemMasterId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "IndentItems",
                newName: "ItemMasterId");

            migrationBuilder.RenameIndex(
                name: "IX_IndentItems_ItemId",
                table: "IndentItems",
                newName: "IX_IndentItems_ItemMasterId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "GRNItems",
                newName: "ItemMasterId");

            migrationBuilder.RenameIndex(
                name: "IX_GRNItems_ItemId",
                table: "GRNItems",
                newName: "IX_GRNItems_ItemMasterId");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "ItemMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "IndentItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Departments",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "BusinessUnits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "TestParameters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestMasterId = table.Column<long>(type: "bigint", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    NormalRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestParameters_TestMasters_TestMasterId",
                        column: x => x.TestMasterId,
                        principalTable: "TestMasters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Member = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(511)", maxLength: 511, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestMasters_SpecimenMasterId",
                table: "TestMasters",
                column: "SpecimenMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_TestParameters_TestMasterId",
                table: "TestParameters",
                column: "TestMasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_GRNItems_ItemMasters_ItemMasterId",
                table: "GRNItems",
                column: "ItemMasterId",
                principalTable: "ItemMasters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IndentItems_ItemMasters_ItemMasterId",
                table: "IndentItems",
                column: "ItemMasterId",
                principalTable: "ItemMasters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItems_ItemMasters_ItemMasterId",
                table: "PurchaseOrderItems",
                column: "ItemMasterId",
                principalTable: "ItemMasters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrders_Vendors_VendorId",
                table: "PurchaseOrders",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReagentMappings_ItemMasters_ItemMasterId",
                table: "ReagentMappings",
                column: "ItemMasterId",
                principalTable: "ItemMasters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockAdjustments_ItemMasters_ItemMasterId",
                table: "StockAdjustments",
                column: "ItemMasterId",
                principalTable: "ItemMasters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockConsumptions_ItemMasters_ItemMasterId",
                table: "StockConsumptions",
                column: "ItemMasterId",
                principalTable: "ItemMasters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockEntries_ItemMasters_ItemMasterId",
                table: "StockEntries",
                column: "ItemMasterId",
                principalTable: "ItemMasters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TestMasters_SpecimenMasters_SpecimenMasterId",
                table: "TestMasters",
                column: "SpecimenMasterId",
                principalTable: "SpecimenMasters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TestMasters_TestMasters_TestMasterId",
                table: "TestMasters",
                column: "TestMasterId",
                principalTable: "TestMasters",
                principalColumn: "Id");
        }
    }
}
