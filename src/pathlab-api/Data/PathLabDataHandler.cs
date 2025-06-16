using ILab.Extensionss.Common;
using ILab.Extensionss.Data;
using ILab.Extensionss.Data.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PathlabApi.Data.Models;
using System.Data;
namespace PathlabApi.Data;

public class PathLabDataHandler : LabDataHandler
{

    public readonly LabDataHandler handler;
    public PathLabDataHandler(DbContext dbContext,
    ILogger<PathLabDataHandler> logger)
        : base(dbContext, logger)
    {

    }

    public ModuleIdentity Identity { get; set; }


    public override IQueryable<T> FilterIdentity<T>(DbSet<T> dbSet)
    {
        // This is used to assign entity to member,
        if ((typeof(T).GetInterfaces().Count(p => p == typeof(IAssignable)) > 0)
            || (typeof(T).GetInterfaces().Count(p => p == typeof(IApproval)) > 0))
        {
            var name = typeof(T).Name;
            var query = dbSet
            .Select(act => new
            {
                data = act,
                Log = dbContext.Set<ApplicationLog>()
                    .Where(apl => apl.EntityId == act.Id && apl.Member.Equals(Identity.Member) && apl.Name.Equals(name))
                    .OrderByDescending(apl => apl.Date)
                    .Select(apl => new { apl.ActivityType, apl.Member, apl.Date })
                    .FirstOrDefault()
            })
            .Where(x => x.Log != null && x.Log.ActivityType != StatusType.UnAssigned && x.data.Status != StatusType.Deleted)
            .Select(x => x.data)
            .AsQueryable();

            return query;
        }

        return dbSet
            .Where(p => p.Key == Identity.Key && p.Status != StatusType.Deleted)
            .AsQueryable();
    }
       

    public dynamic GetAllAssignedUsers(string module, long id)
    {
        var result = dbContext.Set<ApplicationLog>()
                    .Select(p => new
                    {
                        p.Member,
                        p.EntityId,
                        data = dbContext.Set<ApplicationLog>()
                            .Where(apl => apl.EntityId == id && apl.Name.Equals(module) &&
                            apl.EntityId == p.EntityId && apl.Name == p.Name && apl.Member == p.Member)
                            .OrderByDescending(apl => apl.Date)
                            .Select(apl => new { apl.ActivityType, apl.Member, apl.Date })
                            .FirstOrDefault()
                    })
                    .Where(x => x.data != null && x.data.ActivityType != StatusType.UnAssigned)
                    .Select(a => new { a.EntityId, a.Member })
                    .Distinct();

        return result;
    }

    public override async Task<long> AddAsync<T>(T item, CancellationToken cancellationToken)
    {
        item.Status = StatusType.Draft;
        item.Date = DateTime.UtcNow;
        item.Member = Identity.Member;
        item.Key = Identity.Key;

        if (typeof(T).GetInterfaces().Count(p => p == typeof(IAssignable)) > 0)
        {
            var assignableItem = (IAssignable)item;
            if (assignableItem.ProjectId == null && assignableItem.ParentId != null)
            {
                assignableItem.ProjectId = getProjectId(item);
            }
        }
        try
        {
            var id = await base.AddAsync(item, cancellationToken);
            await LogLabModelLog(item, StatusType.Draft, cancellationToken);

            return id;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, $"Exception in AddAsync method and details: '{ex.Message}'");
            throw;
        }
    }

    public override async Task<long> EditAsync<T>(T item, CancellationToken cancellationToken)
    {
        item.Status = StatusType.Modified;
        item.Member = Identity.Member;
        item.Date = DateTime.UtcNow;
        //item.Key = Identity.Key; Not changing key anymore

        if (typeof(T).GetInterfaces().Count(p => p == typeof(IAssignable)) > 0)
        {
            var assignableItem = (IAssignable)item;
            if (assignableItem.ProjectId == null && assignableItem.ParentId != null)
            {
                assignableItem.ProjectId = getProjectId(item);
            }
        }

        try
        {
            var id = await base.EditAsync(item, cancellationToken);

            await LogLabModelLog(item, StatusType.Modified, cancellationToken);

            return id;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, $"Exception in EditAsync method and details: '{ex.Message}'");
            throw;
        }
    }

    private long? getProjectId<T>(T item)
        where T : LabModel
    {
        if (typeof(T).GetInterfaces().Count(p => p == typeof(IAssignable)) > 0)
        {
            var assignableItem = (IAssignable)item;
            if (assignableItem != null
                && assignableItem.ProjectId == null
                && assignableItem.ParentId != null)
            {
                
            }
        }
        return null;

    }
    

    public override async Task<long> DeleteAsync<T>(T item, CancellationToken cancellationToken)
    {
        item.Status = StatusType.Deleted;
        item.Member = Identity.Member;
        item.Date = DateTime.UtcNow;
        //item.Key = Identity.Key; Not changing key anymore

        try
        {
            var id = await base.EditAsync(item, cancellationToken);

            await LogLabModelLog(item, StatusType.ModuleDeleted, cancellationToken);

            return id;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, $"Exception in DeleteAsync method and details: '{ex.Message}'");
            throw;
        }
    }

    public dynamic GetChallanReportDateWise(DateTime startDate, DateTime endDate)
    {
        ListOptions option = new();

        option.SearchCondition = new Condition()
        {
            Name = "DocumentDate",
            Value = startDate,
            Operator = OperatorType.GreaterThan,
            And = new Condition()
            {
                Name = "DocumentDate",
                Value = endDate,
                Operator = OperatorType.LessThan
            }
        };
        //var levelSetups = Load<LevelSetup>(option).Items;
        //var details = dbContext.Set<LevelSetupDetails>()
        //    .ToList();

        //var final = details.Join(levelSetups,
        //        d => d.HeaderId,
        //        m => m.Id,
        //        (d, m) => new ChallanReport()
        //        {
        //            Project = m.ProjectName,
        //            DocumentDate = m.DocumentDate,
        //            VechileNo = m.VechileNo,
        //            TrackingNo = m.TrackingNo,
        //            SupplierName = m.SupplierName,
        //            QCChargeName = m.InChargeName,
        //            Item = d.Name,
        //            Quantity = d.Quantity,
        //            Price = d.Price,
        //            UOM = d.UOMName,
        //            ReceiverStatus = d.ReceiverStatus,
        //            ReceiverRemarks = d.ReceiverRemarks,
        //            QCStatus = d.QualityStatus,
        //            QCRemarks = d.QualityRemarks,
        //            DirectorFinalRemarks = m.ApprovedRemarks
        //        });

        return "final";
    }
    public async Task<long> EditPartialAsync<T>(T item, string module, CancellationToken cancellationToken)
        where T : LabModel
    {
        item.Member = item.Member != null ? item.Member : Identity.Member; // Allowing Member to be updated
        item.Date = DateTime.UtcNow;
        //item.Key = Identity.Key; Not changing key anymore
        try
        {
            await LogLabModelLog(item, (StatusType)item.Status, cancellationToken);

            if (item.Status.Equals(StatusType.UnAssigned))
            {
                var data = dbContext.Set<ApplicationLog>().Where(l => l.EntityId == item.Id && l.Name.Equals(module)
                && l.ActivityType.Equals(StatusType.Draft)).FirstOrDefault();

                item.Status = StatusType.Draft;
                item.Member = data?.Member;
            }
            var id = await base.EditAsync(item, cancellationToken);

            return id;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, $"Exception in AssignAsync method and details: '{ex.Message}'");
            throw;
        }
    }

    private async Task<long> LogLabModelLog<T>(T item, StatusType activityType, CancellationToken cancellationToken)
    where T : LabModel
    {
        var module = typeof(T);



        var jitem = JsonConvert.SerializeObject(item,
        Newtonsoft.Json.Formatting.None,
        new JsonSerializerSettings()
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        });

        var log = new ApplicationLog()
        {
            Date = DateTime.UtcNow,
            EntityId = item.Id,
            Name = module.Name,
            ActivityType = activityType,
            Member = item.Member,
            Key = item.Key,
            ContentHistory = jitem
        };
        try
        {
            dbContext.Set<ApplicationLog>().Add(log);
            return await dbContext.SaveChangesAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, $"Exception in DeleteAsync method and details: '{ex.Message}'");
            throw;
        }
    }
}

public class ModuleIdentity
{
    public ModuleIdentity(string member, string key)
    {
        Member = member;
        Key = key;
    }
    public string Member { get; }
    public string Key { get; }
}