using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laboratory.Models
{
    public class TestMaster : LaboratoryModel
    {
        [MaxLength(20)]
        public virtual string? Code { get; set; }
        public virtual string? Description { get; set; }
        public virtual long? CompanyId { get; set; }
        [ForeignKey("SpecimenMaster")]
        public virtual long? SpecimenId { get; set; }
        [JsonIgnore]
        public virtual SpecimenMaster? SpecimenMaster { get; set; }
        public virtual long? DepartmentId { get; set; }

        [JsonIgnore]
        public virtual ICollection<ParameterMaster>? ParameterMasters { get; set; }

        [JsonIgnore]
        public virtual ICollection<ReferralDoctorFeeSetup>? ReferralDoctorFeeSetups { get; set; }
        [JsonIgnore]
        public virtual ICollection<SampleCollectorFeeSetup>? SampleCollectorFeeSetups { get; set; }
        [JsonIgnore]
        public virtual ICollection<TestReagentMapping>? TestReagentMappings { get; set; }
    }
}
