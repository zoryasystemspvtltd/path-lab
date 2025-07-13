using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class PurchaseOrderItem : LabModel
    {
        [ForeignKey("PurchaseOrder")]
        public virtual long? PurchaseOrderId { get; set; }
        [JsonIgnore]
        public virtual PurchaseOrder? PurchaseOrder { get; set; }

        [ForeignKey("ItemMaster")]
        public virtual long? ItemMasterId { get; set; }
        [JsonIgnore]
        public virtual ItemMaster? ItemMaster { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }

        [JsonIgnore]
        public virtual ICollection<GRN>? GRNs { get; set; }
    }
}
