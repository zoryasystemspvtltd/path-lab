using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathlabApi.Data.Models
{
    public class TestMaster : LabModel
    {
        [ForeignKey("SpecimenMaster")]
        public virtual long? SpecimenMasterId { get; set; }
        [JsonIgnore]
        public virtual SpecimenMaster? SpecimenMaster { get; set; }

        [JsonIgnore]
        public virtual ICollection<TestParameter>? TestParameters { get; set; }

        [JsonIgnore]
        public virtual ICollection<TestMaster>? TestMasters { get; set; }
    }
}
