using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class PurchaseOrder : PathLabModel
    {   
        public DateTime? PurchaseOrderDate { get; set; }      
       
        [ForeignKey("Supplier")]
        public virtual long? SupplierId { get; set; }
        [JsonIgnore]
        public virtual Supplier? Supplier { get; set; }
        [ForeignKey("Company")]
        public virtual long? CompanyId { get; set; }
        [JsonIgnore]
        public virtual Company? Company { get; set; }
        [MaxLength(20)]
        public string? ApprovalStatus { get; set; }

        public virtual long? FinancialYearId { get; set; }
        [JsonIgnore]
        public virtual ICollection<GRN>? GRNs { get; set; }
        [JsonIgnore]
        public virtual ICollection<PurchaseOrderItem>? PurchaseOrderItems { get; set; }
    }
}
