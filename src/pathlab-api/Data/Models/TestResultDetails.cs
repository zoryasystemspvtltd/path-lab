using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathlabApi.Data.Models
{
    public class TestResultDetails : LabModel
    {
        [MaxLength(30)]
        public virtual string? LISParamCode { get; set; }        
        public virtual string? LISParamValue { get; set; }
        [MaxLength(30)]
        public virtual string? LISParamUnit { get; set; } 
       
        [ForeignKey("TestResult")]
        public long TestResultId { get; set; }
        [JsonIgnore]
        public virtual TestResult? TestResult { get; set; }

        
    }
}

