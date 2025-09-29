using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class ReagentMapping : PathLabModel
    { 
        public virtual long? TestId { get; set; }
       
        [ForeignKey("ItemMaster")]
        public virtual long? ItemId { get; set; }
        [JsonIgnore]
        public virtual ItemMaster? ItemMaster { get; set; }
       
        public int? QuantityUsed { get; set; }
    }
}
