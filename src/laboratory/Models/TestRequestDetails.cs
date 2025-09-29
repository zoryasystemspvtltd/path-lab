using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laboratory.Models
{
    public class TestRequestDetails : LaboratoryModel
    {       
        [MaxLength(30)]
        public virtual string? SampleNo { get; set; }
        [MaxLength(20)]
        public virtual string? TestCode { get; set; }
        [MaxLength(100)]
        public virtual string? TestName { get; set; }
        public DateTime SampleCollectionDate { get; set; }
        public DateTime SampleReceivedDate { get; set; }
        [MaxLength(20)]
        public virtual string? SpecimenCode { get; set; }
        [MaxLength(100)]
        public virtual string? SpecimenName { get; set; }       
        public virtual string? ReportStatus { get; set; }        
        [MaxLength(20)]
        public virtual string? IPNo { get; set; }
        [MaxLength(20)]
        public virtual string? BedNo { get; set; }
        [MaxLength(20)]
        public virtual string? MRNo { get; set; }
        [MaxLength(20)]
        public virtual string? HISRequestId { get; set; }
        [MaxLength(20)]
        public virtual string? HISRequestNo { get; set; }       
        public virtual long? DepartmentId { get; set; }     
        public virtual long? BusinessUnitId { get; set; }
        [NotMapped]
        public virtual bool RequireReOpenion { get; set; }
        [NotMapped]
        public virtual string? LISTestCode { get; set; }
               
        [ForeignKey("Patient")]
        public long PatientId { get; set; }
        public virtual PatientDetails? Patient { get; set; }

        [JsonIgnore]
        public virtual IEnumerable<TestRequestParameter>? TestRequestParameters { get; set; }
    }
}
