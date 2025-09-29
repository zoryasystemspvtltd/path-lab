using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class GRNItem : PathLabModel
    {   
        public DateTime? GRNDate { get; set; }      
       
        [ForeignKey("GRN")]
        public virtual long? GRNId { get; set; }
        [JsonIgnore]
        public virtual GRN? GRN { get; set; }

        [ForeignKey("ItemMaster")]
        public virtual long? ItemId { get; set; }
        [JsonIgnore]
        public virtual ItemMaster? ItemMaster { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? Expiry { get; set; }
        public int? Quantity { get; set; }
    }
}
