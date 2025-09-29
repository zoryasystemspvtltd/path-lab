using Inventory.Models.Common;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class ItemGroup : PathLabModel
    {
        [ForeignKey("ItemType")]
        public virtual long? ItemTypeId { get; set; }
        [JsonIgnore]
        public virtual ItemType? ItemType { get; set; }
        [JsonIgnore]
        public virtual ICollection<ItemMaster>? ItemMasters { get; set; }
    }
}
