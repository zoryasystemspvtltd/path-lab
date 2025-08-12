using System.ComponentModel.DataAnnotations;
using ILab.Extensionss.Data.Models;

namespace Laboratory.Models
{
    public class Department : LaboratoryModel
    {
        [StringLength(10)]
        public string? Code { get; set; }
    }
}