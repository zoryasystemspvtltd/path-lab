using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class Supplier : PathLabModel
    {
        [MaxLength(20)]
        public virtual string? GSTIN { get; set; }
        [MaxLength(20)]
        public virtual string? PAN { get; set; }
        public virtual string? ContactInfo { get; set; }

        [ForeignKey("Company")]
        public virtual long? CompanyId { get; set; }
        [JsonIgnore]
        public virtual Company? Company { get; set; }
        [JsonIgnore]
        public virtual ICollection<PurchaseOrder>? PurchaseOrders { get; set; }
    }
}
