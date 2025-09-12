using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class Company : LabModel
    {
        public string?Description { get; set; }       

        [ForeignKey("Enterprise")]
        public virtual long? EnterpriseId { get; set; }
        [JsonIgnore]
        public virtual Enterprise? Enterprise { get; set; }
        [MaxLength(50)]
        public virtual string? ModifiedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }       
    }
}
