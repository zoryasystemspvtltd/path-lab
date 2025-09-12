using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PathlabApi.Data.Models
{
    public class SpecimenMaster : LabModel
    {
        [MaxLength(20)]
        public virtual string? Code { get; set; }
        public virtual long? BusinessUnitId { get; set; }
        [JsonIgnore]
        public virtual ICollection<TestMaster>? TestMasters { get; set; }
    }
}
