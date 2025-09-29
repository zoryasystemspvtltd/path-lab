using Inventory.Models.Common;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class Company : PathLabModel
    {
        [ForeignKey("Enterprise")]
        public virtual long? EnterpriseId { get; set; }
        [JsonIgnore]
        public virtual Enterprise? Enterprise { get; set; }
        [MaxLength(50)]
        public virtual string? ModifiedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        [JsonIgnore]
        public virtual ICollection<BusinessUnit>? BusinessUnits { get; set; }
    }
}
