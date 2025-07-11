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
   
    public virtual DbSet<Attachment> Attachments { get; set; }

    #region Masters
    public virtual DbSet<TestMaster> TestMasters { get; set; }
    public virtual DbSet<TestParameter> TestParameters { get; set; }
    public virtual DbSet<SpecimenMaster> SpecimenMasters { get; set; }
    public virtual DbSet<Department> Departments { get; set; }
    #endregion

}