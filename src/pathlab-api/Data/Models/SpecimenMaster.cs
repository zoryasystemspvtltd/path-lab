using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;

namespace PathlabApi.Data.Models
{
    public class SpecimenMaster : LabModel
    {
        [JsonIgnore]
        public virtual ICollection<TestMaster>? TestMasters { get; set; }
    }
}
