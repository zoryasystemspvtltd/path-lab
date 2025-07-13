using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class StockAdjustment : LabModel
    {    
       
        [ForeignKey("Store")]
        public virtual long? StoreId { get; set; }
        [JsonIgnore]
        public virtual Store? Store { get; set; }

        [ForeignKey("ItemMaster")]
        public virtual long? ItemMasterId { get; set; }
        [JsonIgnore]
        public virtual ItemMaster? ItemMaster { get; set; }

        public string? Reason { get; set; }
        public int? QuantityAdjusted { get; set; }       
    }
}
