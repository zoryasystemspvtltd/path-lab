using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class Ledger : LabModel
    {
        public virtual long? AccountGroupId { get; set; }       

        [ForeignKey("Company")]
        public virtual long? CompanyId { get; set; }
        [JsonIgnore]
        public virtual Company? Company { get; set; }
        [MaxLength(50)]
        public virtual string? LedgerType { get; set; }
    }
}
