using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryApi.Data.Models
{
    public class GRN : LabModel
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
        [JsonIgnore]
        public virtual ICollection<GRNItem>? GRNItems { get; set; }
    }
}
