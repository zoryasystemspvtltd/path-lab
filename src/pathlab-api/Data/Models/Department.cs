using System.ComponentModel.DataAnnotations;
using ILab.Extensionss.Data.Models;

namespace PathlabApi.Data.Models
{
    public class Department : LabModel, IGlobal
    {
        [MaxLength(20)]
        public string? Code { get; set; }
    }
}