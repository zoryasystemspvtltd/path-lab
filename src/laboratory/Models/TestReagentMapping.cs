using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laboratory.Models
{
    public class TestReagentMapping : LaboratoryModel
    {
        public virtual long? CompanyId { get; set; }

        [ForeignKey("TestMaster")]
        public virtual long? TestId { get; set; }
        [JsonIgnore]
        public virtual TestMaster? TestMaster { get; set; }

        [ForeignKey("TestReagentMaster")]
        public virtual long? ReagentId { get; set; }
        [JsonIgnore]
        public virtual TestReagentMaster? TestReagentMaster { get; set; }
        public virtual decimal QuantityRequired { get; set; }
        [MaxLength(20)]
        public virtual string? UnitOfMeasure { get; set; }
        [MaxLength(50)]
        public virtual string? ModifiedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
    }
}
