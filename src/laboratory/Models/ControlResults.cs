using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Laboratory.Models
{
    public class ControlResults : LaboratoryModel
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
