using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryApi.Data.Models
{
    public class GRNItem : LabModel
    {   
        public DateTime? GRNDate { get; set; }      
       
        [ForeignKey("GRN")]
        public virtual long? GRNId { get; set; }
        [JsonIgnore]
        public virtual GRN? GRN { get; set; }

        [ForeignKey("ItemMaster")]
        public virtual long? ItemMasterId { get; set; }
        [JsonIgnore]
        public virtual ItemMaster? ItemMaster { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? Expiry { get; set; }
        public int? Quantity { get; set; }
    }
}
