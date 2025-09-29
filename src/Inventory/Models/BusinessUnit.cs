using Inventory.Models.Common;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class BusinessUnit : PathLabModel
    {
        [MaxLength(50)]
        public string? Type { get; set; }

        [ForeignKey("Enterprise")]
        public virtual long? EnterpriseId { get; set; }
        [JsonIgnore]
        public virtual Enterprise? Enterprise { get; set; }

        [ForeignKey("Companies")]
        public virtual long? CompanyId { get; set; }
        [JsonIgnore]
        public virtual Company? Companies { get; set; }
        [JsonIgnore]
        public virtual ICollection<Indent>? Indents { get; set; }

        [JsonIgnore]
        public virtual ICollection<GRN>? GRNs { get; set; }

        [JsonIgnore]
        public virtual ICollection<Store>? Stores { get; set; }
    }
}
