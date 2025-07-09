using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using PathlabApi.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryApi.Data.Models
{
    public class Store : LabModel
    {
        [ForeignKey("BusinessUnit")]
        public virtual long? BusinessUnitId { get; set; }
        [JsonIgnore]
        public virtual BusinessUnit? BusinessUnit { get; set; }

        [JsonIgnore]
        public virtual ICollection<StockAdjustment>? StockAdjustments { get; set; }
        [JsonIgnore]
        public virtual ICollection<StockEntry>? StockEntries { get; set; }
    }
}
