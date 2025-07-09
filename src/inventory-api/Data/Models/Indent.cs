using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryApi.Data.Models
{
    public class Indent : LabModel
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
