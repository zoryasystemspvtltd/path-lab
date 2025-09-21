using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;

namespace Inventory.Models
{
    
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
