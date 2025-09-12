using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathlabApi.Data.Models
{
    public class EquipmentMaster : LabModel
    {
        [MaxLength(50)]
        public virtual string? Model { get; set; }

        [MaxLength(50)]
        public virtual string? AccessKey { get; set; }
        public virtual long? BusinessUnitId { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<TestMappingMaster>? TestMapping { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<TestResult>? TestResults { get; set; }

        [NotMapped]
        public bool IsAlive { get; set; }
        [NotMapped]
        public DateTime HeartBeatTime { get; set; }
    }
}
