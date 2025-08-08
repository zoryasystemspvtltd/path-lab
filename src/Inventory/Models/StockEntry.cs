using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class StockEntry : PathLabModel
    {
        [ForeignKey("Store")]
        public virtual long? StoreId { get; set; }
        [JsonIgnore]
        public virtual Store? Store { get; set; }

        [ForeignKey("ItemMaster")]
        public virtual long? ItemMasterId { get; set; }
        [JsonIgnore]
        public virtual ItemMaster? ItemMaster { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? Expiry { get; set; }
        public int? QuantityAvailable { get; set; }       
    }
}
