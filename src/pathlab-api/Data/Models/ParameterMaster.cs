using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathlabApi.Data.Models
{
    public class ParameterMaster : LabModel
    {       
        [MaxLength(20)]
        public virtual string? Code { get; set; }
        public virtual string? Description { get; set; }
        [MaxLength(20)]
        public virtual string? TestCode { get; set; }
        [MaxLength(50)]
        public virtual string? LISParamCode { get; set; }
        [MaxLength(10)]
        public string? ParamUnit { get; set; }
        [MaxLength(50)]
        public string? ParamMethod { get; set; }
        [ForeignKey("TestMaster")]
        public virtual long? TestId { get; set; }
        [JsonIgnore]
        public virtual TestMaster? TestMaster { get; set; }
        public virtual long? BusinessUnitId { get; set; }
    }
}
