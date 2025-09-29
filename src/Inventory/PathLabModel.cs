using ILab.Extensionss.Data;
using ILab.Extensionss.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Inventory
{
    public abstract class PathLabModel : LabModel
    {
        public virtual string? Code { get; set; }
        public virtual string? Description { get; set; }
    }
}
