using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class IndentItem : LabModel
    {   
        public DateTime? GRNDate { get; set; }      
       
        [ForeignKey("Indent")]
        public virtual long? IndentId { get; set; }
        [JsonIgnore]
        public virtual Indent? Indent { get; set; }

        [ForeignKey("ItemMaster")]
        public virtual long? ItemMasterId { get; set; }
        [JsonIgnore]
        public virtual ItemMaster? ItemMaster { get; set; }
       
        public int? Quantity { get; set; }
    }
}
