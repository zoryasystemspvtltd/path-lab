using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models.Common
{
    
    public class Enterprise : PathLabModel
    {       
        [MaxLength(50)]
        public virtual string? ModifiedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        [JsonIgnore]
        public virtual ICollection<BusinessUnit>? BusinessUnits { get; set; }
        [JsonIgnore]
        public virtual ICollection<Company>? Companies { get; set; }
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
        [JsonIgnore]
        public virtual ICollection<ItemMaster>? ItemMasters { get; set; }
    }    
}
