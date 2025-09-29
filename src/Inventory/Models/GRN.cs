using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class GRN : PathLabModel
    {   
        public DateTime? GRNDate { get; set; }      
       
        [ForeignKey("BusinessUnit")]
        public virtual long? BusinessUnitId { get; set; }
        [JsonIgnore]
        public virtual BusinessUnit? BusinessUnit { get; set; }

        [ForeignKey("PurchaseOrder")]
        public virtual long? PurchaseOrderId { get; set; }
        [JsonIgnore]
        public virtual PurchaseOrder? PurchaseOrder { get; set; }
        public virtual DateTime? ReceivedDate { get; set; }
        [MaxLength(50)]
        public virtual string? PerformedBy { get; set; }
        public virtual long? FinancialYearId { get; set; }       
        [JsonIgnore]
        public virtual ICollection<GRNItem>? GRNItems { get; set; }
    }
}
