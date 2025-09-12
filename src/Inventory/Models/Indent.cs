using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class Indent : LabModel
    {   
        public DateTime? IndentDate { get; set; }       
        [ForeignKey("BusinessUnit")]
        public virtual long? BusinessUnitId { get; set; }
        [JsonIgnore]
        public virtual BusinessUnit? BusinessUnit { get; set; }
        public virtual string? Purpose { get; set; }
        public virtual long? FinancialYearId { get; set; }
        [JsonIgnore]
        public virtual ICollection<IndentItem>? IndentItems { get; set; }
        public virtual DateOnly? RequiredByDate { get; set; }
    }
}
