using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class ItemMaster : PathLabModel
    {
        [ForeignKey("ItemType")]
        public virtual long? ItemTypeId { get; set; }
        [JsonIgnore]
        public virtual ItemType? ItemType { get; set; }

        [ForeignKey("ItemGroup")]
        public virtual long? ItemGroupId { get; set; }
        [JsonIgnore]
        public virtual ItemGroup? ItemGroup { get; set; }
        [ForeignKey("UnitOfMeasure")]
        public virtual long? UnitOfMeasureId { get; set; }
        [JsonIgnore]
        public virtual UnitOfMeasure? UnitOfMeasure { get; set; }

        public virtual decimal? Rate { get; set; }
        public virtual bool? Centralized { get; set; }
        [JsonIgnore]
        public virtual ICollection<StockConsumption>? StockConsumptions { get; set; }

        [JsonIgnore]
        public virtual ICollection<StockAdjustment>? StockAdjustments { get; set; }

        [JsonIgnore]
        public virtual ICollection<StockEntry>? StockEntries { get; set; }

        [JsonIgnore]
        public virtual ICollection<GRNItem>? GRNItems { get; set; }

        [JsonIgnore]
        public virtual ICollection<PurchaseOrderItem>? PurchaseOrderItems { get; set; }

        [JsonIgnore]
        public virtual ICollection<IndentItem>? IndentItems { get; set; }

        [JsonIgnore]
        public virtual ICollection<ReagentMapping>? ReagentMappings { get; set; }
    }
}
