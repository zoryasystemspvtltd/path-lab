using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathlabApi.Data.Models
{
    public class TestRequestParameter : LabModel
    {
        [MaxLength(20)]
        public virtual string? Code { get; set; }
        [MaxLength(20)]
        public virtual string? TestCode { get; set; }
        
        [ForeignKey("TestRequestDetails")]
        public long TestRequestDetailsId { get; set; }
        [JsonIgnore]
        public virtual TestRequestDetails? TestRequestDetails { get; set; }
    }
}
