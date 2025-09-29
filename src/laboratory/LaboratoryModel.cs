using ILab.Extensionss.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace Laboratory.Models
{
    public abstract class LaboratoryModel : LabModel
    {
        [MaxLength(20)]
        public virtual string? Code { get; set; }
        public virtual string? Description { get; set; }
    }
}
