using ILab.Extensionss.Data.Models;
using Inventory.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathlabApi.Data.Models
{
    public class ReferralDoctorFeeSetup : LabModel
    {
        public virtual long? BusinessUnitId { get; set; }        

        [ForeignKey("ReferralDoctorMaster")]
        public virtual long? ReferralDoctorId { get; set; }
        [JsonIgnore]
        public virtual ReferralDoctorMaster? ReferralDoctorMaster { get; set; }

        [ForeignKey("TestMaster")]
        public virtual long? TestId { get; set; }
        [JsonIgnore]
        public virtual TestMaster? TestMaster { get; set; }

        [MaxLength(20)]
        public virtual string? FeeType { get; set; }        
        public virtual decimal FeeValue { get; set; }       
        public virtual DateOnly EffectiveFrom { get; set; }        
        public virtual DateOnly? EffectiveTo { get; set; }
        [MaxLength(50)]
        public virtual string? ModifiedBy { get; set; }       
        public virtual DateTime? ModifiedDate { get; set; }
    }
}
