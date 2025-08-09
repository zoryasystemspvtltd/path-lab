using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;

namespace Laboratory.Data.Models
{
    public class SpecimenMaster : LabModel
    {
        [JsonIgnore]
        public virtual ICollection<TestMaster>? TestMasters { get; set; }
    }
}
