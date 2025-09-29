using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Laboratory.Models
{
    public class SpecimenMaster : LaboratoryModel
    {
        [MaxLength(20)]
        public virtual string? Code { get; set; }
        public virtual long? BusinessUnitId { get; set; }
        [JsonIgnore]
        public virtual ICollection<TestMaster>? TestMasters { get; set; }
    }
}
