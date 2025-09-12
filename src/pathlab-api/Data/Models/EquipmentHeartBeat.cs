using ILab.Extensionss.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace PathlabApi.Data.Models
{  
    public class EquipmentHeartBeat : LabModel
    {
        [MaxLength(50)]
        public virtual string? AccessKey { get; set; }
        public bool IsAlive { get; set; }
        public virtual long? BusinessUnitId { get; set; }
    }
}
