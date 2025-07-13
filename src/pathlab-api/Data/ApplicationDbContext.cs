using Inventory.Models;
using Microsoft.EntityFrameworkCore;
using PathlabApi.Data.Models;
namespace PathlabApi.Data;


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);       
        SeedData(builder);
    }
    private void SeedData(ModelBuilder builder)
    {
        var rootKey = "1536B022-C5C9-4358-BB6A-466F2075B7D4"; 
    }

    public virtual DbSet<ApplicationLog> ApplicationLogs { get; set; }
   

    #region Masters
    public virtual DbSet<TestMaster> TestMasters { get; set; }
    public virtual DbSet<TestParameter> TestParameters { get; set; }
    public virtual DbSet<SpecimenMaster> SpecimenMasters { get; set; }
    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Enterprise> Enterprises { get; set; }
    public virtual DbSet<BusinessUnit> BusinessUnits { get; set; }
    public virtual DbSet<Vendor> Vendors { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
    public virtual DbSet<ItemMaster> ItemMasters { get; set; }
    public virtual DbSet<Store> Stores { get; set; }
    #endregion

    #region Transaction
    public virtual DbSet<Attachment> Attachments { get; set; }
    public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
    public virtual DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }
    public virtual DbSet<GRN> GRNs { get; set; }
    public virtual DbSet<GRNItem> GRNItems { get; set; }
    public virtual DbSet<Indent> Indents { get; set; }
    public virtual DbSet<IndentItem> IndentItems { get; set; }
    public virtual DbSet<StockAdjustment> StockAdjustments { get; set; }
    public virtual DbSet<StockConsumption> StockConsumptions { get; set; }
    public virtual DbSet<StockEntry> StockEntries { get; set; }
    public virtual DbSet<ReagentMapping> ReagentMappings { get; set; }

    #endregion
}