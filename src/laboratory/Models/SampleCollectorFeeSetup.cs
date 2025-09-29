using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laboratory.Models
{
    public class SampleCollectorFeeSetup : LaboratoryModel
    {
        public virtual long? BusinessUnitId { get; set; }
        
        [ForeignKey("SampleCollectorMaster")]
        public virtual long? CollectorId { get; set; }
        [JsonIgnore]
        public virtual SampleCollectorMaster? SampleCollectorMaster { get; set; }

        [ForeignKey("TestMaster")]
        public virtual long? TestId { get; set; }
        [JsonIgnore]
        public virtual TestMaster? TestMaster { get; set; }

        [MaxLength(20)]
        public virtual string? FeeType { get; set; }        
        public virtual decimal FeeValue { get; set; }       
        public virtual DateOnly EffectiveFrom { get; set; }        
        public virtual DateOnly? EffectiveTo { get; set; }
        [MaxLength(100)]
        public virtual string? ModifiedBy { get; set; }       
        public virtual DateTime? ModifiedDate { get; set; }
    }
}
