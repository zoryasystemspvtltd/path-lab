using ILab.Extensionss.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace Inventory
{
    public abstract class PathLabModel : LabModel
    {
        [MaxLength(20)]
        public virtual string? Code { get; set; }
        public virtual string? Description { get; set; }
    }
}
