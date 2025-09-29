using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Laboratory.Models
{
    public class ReferralDoctorMaster : LaboratoryModel
    {
        public virtual long? BusinessUnitId { get; set; }                     
        [MaxLength(100)]
        public virtual string? Specialization { get; set; }
        [MaxLength(20)]
        public virtual string? ContactNumber { get; set; }
        [MaxLength(50)]
        public virtual string? Email { get; set; }
        [MaxLength(150)]
        public virtual string? HospitalAffiliation { get; set; }
        [MaxLength(50)]
        public virtual string? ModifiedBy { get; set; }       
        public virtual DateTime? ModifiedDate { get; set; }

        [JsonIgnore]
        public virtual ICollection<ReferralDoctorFeeSetup>? ReferralDoctorFeeSetups { get; set; }
    }
}
