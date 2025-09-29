using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Laboratory.Models
{
    public class TestReagentMaster : LaboratoryModel
    {
        public virtual long? CompanyId { get; set; }                   
        [MaxLength(50)]       
        public virtual string? BatchNumber { get; set; }       
        public virtual DateOnly ExpiryDate { get; set; }       
        public virtual decimal QuantityAvailable { get; set; }
        [MaxLength(20)]
        public virtual string? UnitOfMeasure { get; set; }
        [MaxLength(50)]
        public virtual string? ModifiedBy { get; set; }       
        public virtual DateTime? ModifiedDate { get; set; }

        [JsonIgnore]
        public virtual ICollection<TestReagentMapping>? TestReagentMappings { get; set; }
    }
}
