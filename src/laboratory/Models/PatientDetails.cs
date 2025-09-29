using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Laboratory.Models
{
    public class PatientDetails : LaboratoryModel
    {      
        public virtual decimal Age { get; set; }
        [MaxLength(10)]
        public virtual string? Gender { get; set; }
        [MaxLength(30)]
        public virtual string? Phone { get; set; }
        [MaxLength(30)]
        public virtual string? Email { get; set; }
        public DateTime DateOfBirth { get; set; }       
       
        [MaxLength(20)]
        public virtual string? HisPatientId { get; set; }
        public virtual long CompanyId { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<TestRequestDetails>? TestRequestDetails { get; set; }

        [JsonIgnore]
        public virtual IEnumerable<TestResult>? TestResults { get; set; }
        
    }
}
