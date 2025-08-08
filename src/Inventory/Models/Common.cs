using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;

namespace Inventory.Models
{
    public abstract class PathLabModel : LabModel
    {
        public virtual string? Code { get; set; }
        public virtual string? Description { get; set; }
    }
    public class Enterprise : PathLabModel
    {
        [JsonIgnore]
        public virtual ICollection<BusinessUnit>? BusinessUnits { get; set; }
    }
    public class Category : PathLabModel
    {
        [JsonIgnore]
        public virtual ICollection<ItemMaster>? ItemMasters { get; set; }
    }
    public class UnitOfMeasure : PathLabModel
    {
        [JsonIgnore]
        public virtual ICollection<ItemMaster>? ItemMasters { get; set; }
    }
    public class Vendor : PathLabModel
    {
        public string? Contact { get; set; }

        [JsonIgnore]
        public virtual ICollection<PurchaseOrder>? PurchaseOrders { get; set; }
    }
}
