using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Laboratory.Models
{
    public class TestMappingMaster : LaboratoryModel
    {
        [MaxLength(20)]
        public virtual string? TestCode { get; set; }
        [MaxLength(20)]
        public virtual string? SpecimenCode { get; set; }
        [MaxLength(20)]
        public virtual string? LISTestCode { get; set; }
        [MaxLength(100)]
        public virtual string? LISTestCodeDescription { get; set; }
        [MaxLength(30)]
        public virtual string? GroupName { get; set; }

        [ForeignKey("Equipment")]
        public virtual long EquipmentId { get; set; }

        [JsonIgnore]
        public virtual EquipmentMaster? Equipment { get; set; }

        [JsonIgnore]
        public virtual IEnumerable<ParameterMaster>? ParameterMasters { get; set; }
    }
}
