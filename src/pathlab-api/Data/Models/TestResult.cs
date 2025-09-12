using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathlabApi.Data.Models
{
    public class TestResult : LabModel
    {
        [MaxLength(30)]
        public virtual string? SampleNo { get; set; }
        [MaxLength(30)]
        public virtual string? TestCode { get; set; }
        [MaxLength(30)]
        public virtual string? LISTestCode { get; set; }
        [MaxLength(30)]
        public virtual string? SpecimenCode { get; set; }
        public DateTime ResultDate { get; set; }
        public DateTime SampleCollectionDate { get; set; }
        public DateTime SampleReceivedDate { get; set; }
        public DateTime? AuthorizationDate { get; set; }
        [MaxLength(30)]
        public virtual string? AuthorizedBy { get; set; }
        public DateTime? ReviewDate { get; set; }
        [MaxLength(30)]
        public virtual string? ReviewedBy { get; set; }
        public virtual string? TechnicianNote { get; set; }
        public virtual string? DoctorNote { get; set; } 
        
        [ForeignKey("Patient")]
        public virtual long PatientId { get; set; }
        public virtual PatientDetails? Patient { get; set; }
        public virtual long TestRequestId { get; set; }        

        [ForeignKey("Equipment")]
        public virtual long EquipmentId { get; set; }

        [JsonIgnore]
        public virtual EquipmentMaster? Equipment { get; set; }      
        public virtual long? BusinessUnitId { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<TestResultDetails>? TestResultDetails { get; set; }
    }
}
