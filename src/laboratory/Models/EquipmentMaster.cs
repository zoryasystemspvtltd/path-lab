using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laboratory.Models
{
    public class EquipmentMaster : LaboratoryModel
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
