using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;

namespace Inventory.Models
{
    public class Enterprise : LabModel
    {
        [JsonIgnore]
        public virtual ICollection<BusinessUnit>? BusinessUnits { get; set; }
    }
    public class Category : LabModel
    {
        [JsonIgnore]
        public virtual ICollection<ItemMaster>? ItemMasters { get; set; }
    }
    public class UnitOfMeasure : LabModel
    {
        [JsonIgnore]
        public virtual ICollection<ItemMaster>? ItemMasters { get; set; }
    }
    public class Vendor : LabModel
    {
        public string? Contact { get; set; }

        [JsonIgnore]
        public virtual ICollection<PurchaseOrder>? PurchaseOrders { get; set; }
    }
}
