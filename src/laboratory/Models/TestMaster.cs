using ILab.Extensionss.Data.Models;
using Laboratory;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laboratory.Models
{
    public class TestMaster : LaboratoryModel
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
