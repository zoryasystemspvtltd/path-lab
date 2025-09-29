using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class AccountGroup : PathLabModel
    {
        [MaxLength(50)]
        public string? Type { get; set; }
        public virtual long? ParentGroupId { get; set; }
        public int HierarchyLevel { get; set; }        
    }
}
