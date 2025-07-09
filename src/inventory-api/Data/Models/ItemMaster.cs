using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryApi.Data.Models
{
    public class ItemMaster : LabModel
    {
        public string? Type { get; set; }

        [ForeignKey("Category")]
        public virtual long? CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category? Category { get; set; }

        [ForeignKey("UnitOfMeasure")]
        public virtual long? UnitOfMeasureId { get; set; }
        [JsonIgnore]
        public virtual UnitOfMeasure? UnitOfMeasure { get; set; }

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
