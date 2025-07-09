using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryApi.Data.Models
{
    public class BusinessUnit : LabModel
    {   
        public string? Type { get; set; }      
       
        [ForeignKey("Enterprise")]
        public virtual long? EnterpriseId { get; set; }
        [JsonIgnore]
        public virtual Enterprise? Enterprise { get; set; }

        [JsonIgnore]
        public virtual ICollection<Indent>? Indents { get; set; }

        [JsonIgnore]
        public virtual ICollection<GRN>? GRNs { get; set; }

        [JsonIgnore]
        public virtual ICollection<Store>? Stores { get; set; }
    }
}
