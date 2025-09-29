using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laboratory.Models
{
    public class ControlResultDetails : LaboratoryModel
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
