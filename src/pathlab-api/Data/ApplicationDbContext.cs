using Inventory.Models;
using Inventory.Models.Common;
using Laboratory.Models;
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
        builder.Entity<SampleCollectorMaster>()
           .Property(p => p.IsInternal).HasDefaultValue(1);
        SeedData(builder);
    }
    private void SeedData(ModelBuilder builder)
    {
        var rootKey = "1536B022-C5C9-4358-BB6A-466F2075B7D4"; 
    }

    public virtual DbSet<ApplicationLog> ApplicationLogs { get; set; }
   

    #region Masters
    public virtual DbSet<TestMaster> TestMasters { get; set; }   
    public virtual DbSet<SpecimenMaster> SpecimenMasters { get; set; }
    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Enterprise> Enterprises { get; set; }    
    public virtual DbSet<Company> Companies { get; set; }
    public virtual DbSet<BusinessUnit> BusinessUnits { get; set; }
    public virtual DbSet<AccountGroup> AccountGroups { get; set; }
    public virtual DbSet<FinancialYear> FinancialYears { get; set; }
    public virtual DbSet<Supplier> Supplier { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
    public virtual DbSet<ItemMaster> ItemMasters { get; set; }
    public virtual DbSet<ItemGroup> ItemGroups { get; set; }
    public virtual DbSet<Store> Stores { get; set; }
    public virtual DbSet<EquipmentMaster> EquipmentMasters { get; set; }
    public virtual DbSet<ParameterMaster> ParameterMaster { get; set; }
    public virtual DbSet<ParameterRangMaster> ParameterRangMasters { get; set; }
    public virtual DbSet<ReferralDoctorMaster> ReferralDoctorMasters { get; set; }
    public virtual DbSet<ReferralDoctorFeeSetup> ReferralDoctorFeeSetups { get; set; }
    public virtual DbSet<SampleCollectorMaster> SampleCollectorMasters { get; set; }   
    public virtual DbSet<SampleCollectorFeeSetup> SampleCollectorFeeSetups { get; set; }
    public virtual DbSet<TestMappingMaster> TestMappingMasters { get; set; }
    public virtual DbSet<TestReagentMaster> TestReagentMasters { get; set; }
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
    public virtual DbSet<Ledger> Ledgers { get; set; }
    public virtual DbSet<PurchaseBill> PurchaseBills { get; set; }
    public virtual DbSet<StockStatus> StockStatus { get; set; }
    public virtual DbSet<ControlResults> ControlResults { get; set; }
    public virtual DbSet<ControlResultDetails> ControlResultDetails { get; set; }
    public virtual DbSet<EquipmentHeartBeat> EquipmentHeartBeats { get; set; }
    public virtual DbSet<PatientDetails> PatientDetails { get; set; }
    public virtual DbSet<TestReagentMapping> TestReagentMapping { get; set; }
    public virtual DbSet<TestRequestDetails> TestRequestDetails { get; set; }
    public virtual DbSet<TestRequestParameter> TestRequestParameters { get; set; }
    public virtual DbSet<TestResult> TestResults { get; set; }
    public virtual DbSet<TestResultDetails> TestResultDetails { get; set; }
    #endregion
}