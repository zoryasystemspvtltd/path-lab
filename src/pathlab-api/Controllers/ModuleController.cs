using ILab.Data;
using ILab.Extensionss.Data.Models;
using Inventory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PathlabApi.Data.Models;

namespace PathlabApi.Controllers;

[ApiController]
[Route("/api/module/")]
[Authorize]
public class ModuleController : ControllerBase
{

    public ModuleController()
    {
    }

    [HttpGet()]
    public List<PathlabModule> Get()
    {
        var asm1 = typeof(PathLabDataService).Assembly;
        var asm2 = typeof(InventoryDataHandler).Assembly;
        var type1 = asm1.GetTypes()
             .Where(p => p.IsSubclassOf(typeof(LabModel)))
             .Select(p => new PathlabModule()
             {
                 Name = p.Name,
                 IsAssignable = p.GetInterfaces().Count(a => a == typeof(IAssignable)) > 0,
                 IsApproval = p.GetInterfaces().Count(a => a == typeof(IApproval)) > 0
             })
             .ToList();
        var type2 = asm2.GetTypes()
            .Where(p => p.IsSubclassOf(typeof(LabModel)))
            .Select(p => new PathlabModule()
            {
                Name = p.Name,
                IsAssignable = p.GetInterfaces().Count(a => a == typeof(IAssignable)) > 0,
                IsApproval = p.GetInterfaces().Count(a => a == typeof(IApproval)) > 0
            })
            .ToList();
       
        var combinedList = new List<PathlabModule>();
        combinedList.AddRange(type1);
        combinedList.AddRange(type2);

        return combinedList;
    }
}

public class PathlabModule
{
    public string? Name { get; set; }
    public bool? IsAssignable { get; set; }
    public bool? IsProject { get; set; }
    public bool? IsCompany { get; set; }
    public bool? IsApproval { get; set; }
    public bool? IsActivity { get; set; }
}
