using Microsoft.EntityFrameworkCore;
using InventoryApi.Data.Models;
namespace InventoryApi.Data;


public class InventoryDbContext : DbContext
{
    public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options)
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

    #region Masters
    public virtual DbSet<Enterprise> Enterprises { get; set; }
    public virtual DbSet<Vendor> Vendors { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }

    #endregion

    #region Transaction
    public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
    #endregion

}