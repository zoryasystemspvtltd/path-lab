using ILab.Data;
using ILab.Extensionss.Data.Models;
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
        var asm = typeof(PathLabDataService).Assembly;
        var type1 = asm.GetTypes()
            .Where(p => p.IsSubclassOf(typeof(LabModel)))
            //.Select(p => new RajModule() { Name = p.Name, IsAssignable = p.BaseType == typeof(IAssignable) })
            .ToList();
        var type = asm.GetTypes()
            .Where(p => p.IsSubclassOf(typeof(LabModel)))
            .Select(p => new PathlabModule()
            {
                Name = p.Name,
                IsAssignable = p.GetInterfaces().Count(a => a == typeof(IAssignable)) > 0,               
                IsApproval = p.GetInterfaces().Count(a => a == typeof(IApproval)) > 0
            })
            .ToList();

        return type;
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
