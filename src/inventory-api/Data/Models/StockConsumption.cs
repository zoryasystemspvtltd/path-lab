using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using PathlabApi.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryApi.Data.Models
{
    public class StockConsumption : LabModel
    {    
       
        [ForeignKey("TestMaster")]
        public virtual long? TestId { get; set; }
        [JsonIgnore]
        public virtual TestMaster? TestMaster { get; set; }

        [ForeignKey("ItemMaster")]
        public virtual long? ItemMasterId { get; set; }
        [JsonIgnore]
        public virtual ItemMaster? ItemMaster { get; set; }

        public DateTime? StockConsumptionDate { get; set; }
        public int? QuantityUsed { get; set; }       
    }
}
