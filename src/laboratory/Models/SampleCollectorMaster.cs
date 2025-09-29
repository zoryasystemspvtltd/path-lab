using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Laboratory.Models
{
    public class SampleCollectorMaster : LaboratoryModel
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
