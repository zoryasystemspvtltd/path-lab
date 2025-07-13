using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class ReagentMapping : LabModel
    {              
       
        public virtual long? TestId { get; set; }
       
        [ForeignKey("ItemMaster")]
        public virtual long? ItemMasterId { get; set; }
        [JsonIgnore]
        public virtual ItemMaster? ItemMaster { get; set; }
       
        public int? QuantityUsed { get; set; }
    }
}
