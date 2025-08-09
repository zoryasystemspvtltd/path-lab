using ILab.Extensionss.Data.Models;
using Laboratory;
using Newtonsoft.Json;

namespace Laboratory.Models
{
    public class SpecimenMaster : LaboratoryModel
    {
        [JsonIgnore]
        public virtual ICollection<TestMaster>? TestMasters { get; set; }
    }
}
