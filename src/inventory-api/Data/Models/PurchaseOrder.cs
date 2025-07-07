using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryApi.Data.Models
{
    public class PurchaseOrder : LabModel
    {   
        public DateTime? PurchaseDate { get; set; }      
       
        [ForeignKey("Vendor")]
        public virtual string? VendorId { get; set; }
        [JsonIgnore]
        public virtual Vendor? Vendor { get; set; }
    }
}
