using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class IndentItem : PathLabModel
    {   
        public DateTime? GRNDate { get; set; }      
       
        [ForeignKey("Indent")]
        public virtual long? IndentId { get; set; }
        [JsonIgnore]
        public virtual Indent? Indent { get; set; }

        [ForeignKey("ItemMaster")]
        public virtual long? ItemId { get; set; }
        [JsonIgnore]
        public virtual ItemMaster? ItemMaster { get; set; }
       
        public virtual decimal? Quantity { get; set; }
    }
}
