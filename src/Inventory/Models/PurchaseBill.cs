using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class PurchaseBill : PathLabModel
    { 
        [ForeignKey("Supplier")]
        public virtual long? SupplierId { get; set; }
        [JsonIgnore]
        public virtual Supplier? Supplier { get; set; }
        public virtual long? FinancialYearId { get; set; }        
    }
}
