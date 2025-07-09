using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using PathlabApi.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryApi.Data.Models
{
    public class ReagentMapping : LabModel
    {              
       
        [ForeignKey("TestMaster")]
        public virtual long? TestMasterId { get; set; }
        [JsonIgnore]
        public virtual TestMaster? TestMaster { get; set; }

        [ForeignKey("ItemMaster")]
        public virtual long? ItemMasterId { get; set; }
        [JsonIgnore]
        public virtual ItemMaster? ItemMaster { get; set; }
       
        public int? QuantityUsed { get; set; }
    }
}
