using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PathlabApi.Migrations
{
    /// <inheritdoc />
    public partial class pathlabmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "UnitOfMeasures",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "UnitOfMeasures",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "StockEntries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "StockEntries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "StockConsumptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "StockConsumptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "StockAdjustments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "StockAdjustments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ReagentMappings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ReagentMappings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PurchaseOrders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PurchaseOrders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PurchaseOrderItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PurchaseOrderItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ItemMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ItemMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Indents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Indents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "IndentItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "IndentItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "GRNs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "GRNs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "GRNItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "GRNItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Enterprises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Enterprises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "BusinessUnits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BusinessUnits",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "UnitOfMeasures");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "UnitOfMeasures");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "StockEntries");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "StockEntries");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "StockConsumptions");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "StockConsumptions");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "StockAdjustments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "StockAdjustments");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ReagentMappings");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ReagentMappings");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PurchaseOrderItems");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PurchaseOrderItems");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ItemMasters");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ItemMasters");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Indents");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Indents");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "IndentItems");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "IndentItems");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "GRNs");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "GRNs");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "GRNItems");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "GRNItems");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Enterprises");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Enterprises");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "BusinessUnits");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "BusinessUnits");
        }
    }
}
