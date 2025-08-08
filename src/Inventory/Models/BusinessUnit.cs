using ILab.Extensionss.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Inventory.Models
{
    public class BusinessUnit : PathLabModel
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
