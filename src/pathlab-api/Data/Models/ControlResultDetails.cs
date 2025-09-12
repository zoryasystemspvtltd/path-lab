using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathlabApi.Data.Models
{
    public class ControlResultDetails : LabModel
    {
        [ForeignKey("ControlResults")]
        public virtual long? ControlResultId { get; set; }
        [JsonIgnore]
        public virtual ControlResults? ControlResults { get; set; }
               
        public virtual long? BusinessUnitId { get; set; }
        [MaxLength(20)]
        public virtual string? LISParamCode { get; set; }
        public virtual string? LISParamValue { get; set; }
        [MaxLength(20)]
        public virtual string? LISParamUnit { get; set; }
    }
}
