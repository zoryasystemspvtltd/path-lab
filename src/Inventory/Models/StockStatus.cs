using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class StockStatus : PathLabModel
    {
        public virtual long? BusinessUnitId { get; set; }       

        [ForeignKey("ItemMaster")]
        public virtual long? ItemId { get; set; }
        [JsonIgnore]
        public virtual ItemMaster? ItemMaster { get; set; }    
        public int? QuantityAvailable { get; set; }       
    }
}
