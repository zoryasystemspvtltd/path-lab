using ILab.Extensionss.Data.Models;
using Inventory.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathlabApi.Data.Models
{
    public class SampleCollectorMaster : LabModel
    {
        public virtual long? BusinessUnitId { get; set; }
      
        [MaxLength(50)]       
        public virtual string? ContactNumber { get; set; }
        [MaxLength(50)]
        public virtual string? Email { get; set; }
        [MaxLength(200)]
        public virtual string? Address { get; set; }
        public virtual bool IsInternal { get; set; }
        [MaxLength(50)]
        public virtual string? ModifiedBy { get; set; }       
        public virtual DateTime? ModifiedDate { get; set; }

        [JsonIgnore]
        public virtual ICollection<SampleCollectorFeeSetup>? SampleCollectorFeeSetups { get; set; }
    }
}
