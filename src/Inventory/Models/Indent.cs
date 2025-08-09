using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class Indent : PathLabModel
    {   
        public DateTime? IndentDate { get; set; }      
       
        [ForeignKey("BusinessUnit")]
        public virtual long? BusinessUnitId { get; set; }
        [JsonIgnore]
        public virtual BusinessUnit? BusinessUnit { get; set; }

        [JsonIgnore]
        public virtual ICollection<IndentItem>? IndentItems { get; set; }
    }
}
