using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryApi.Data.Models
{
    public class PurchaseOrder : LabModel
    {   
        public DateTime? PurchaseOrderDate { get; set; }      
       
        [ForeignKey("Vendor")]
        public virtual long? VendorId { get; set; }
        [JsonIgnore]
        public virtual Vendor? Vendor { get; set; }

        [JsonIgnore]
        public virtual ICollection<GRN>? GRNs { get; set; }
        [JsonIgnore]
        public virtual ICollection<PurchaseOrderItem>? PurchaseOrderItems { get; set; }
    }
}
