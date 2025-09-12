using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class Enterprise : LabModel
    {
        public string? Description { get; set; }
        [MaxLength(50)]
        public virtual string? ModifiedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        [JsonIgnore]
        public virtual ICollection<BusinessUnit>? BusinessUnits { get; set; }
    }
    public class Category : LabModel
    {
        [JsonIgnore]
        public virtual ICollection<ItemMaster>? ItemMasters { get; set; }
    }
    public class ItemType : LabModel
    {
        [JsonIgnore]
        public virtual ICollection<ItemMaster>? ItemMasters { get; set; }
    }
    public class UnitOfMeasure : LabModel
    {
        [JsonIgnore]
        public virtual ICollection<ItemMaster>? ItemMasters { get; set; }
    }    
}
