using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laboratory.Models
{   
    public class ParameterRangMaster : LaboratoryModel
    {
        [MaxLength(20)]
        public string? Code { get; set; }
        [MaxLength(10)]
        public string? Value { get; set; }
        [MaxLength(20)]
        public string? Gender { get; set; }
        public decimal AgeFrom { get; set; }
        public decimal AgeTo { get; set; }
        [MaxLength(20)]
        public string? AgeType { get; set; }
        public decimal MinValue { get; set; }
        public decimal MaxValue { get; set; }              

        [ForeignKey("ParameterMasters")]
        public long ParameterId { get; set; }

        [JsonIgnore]
        public virtual ParameterMaster? ParameterMasters { get; set; }
    }
}
