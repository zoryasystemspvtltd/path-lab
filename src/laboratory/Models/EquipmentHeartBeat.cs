using System.ComponentModel.DataAnnotations;

namespace Laboratory.Models
{  
    public class EquipmentHeartBeat : LaboratoryModel
    {
        [MaxLength(50)]
        public virtual string? AccessKey { get; set; }
        public bool IsAlive { get; set; }
        public virtual long? BusinessUnitId { get; set; }
    }
}
