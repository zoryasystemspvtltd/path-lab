using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PathlabApi.Data.Models
{
    public class ControlResults : LabModel
    {
        [MaxLength(50)]
        public virtual string? SampleNo { get; set; }
        public virtual DateTime? ResultDate { get; set; }
        public virtual int? EquipmentId { get; set; }
        public virtual long? BusinessUnitId { get; set; }
        [JsonIgnore]
        public virtual ICollection<ControlResultDetails>? ControlResultDetails { get; set; }
    }
}
