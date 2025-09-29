using System.ComponentModel.DataAnnotations;
using ILab.Extensionss.Data.Models;

namespace Laboratory.Models
{
    public class Department : LaboratoryModel
    {
        [MaxLength(20)]
        public string? Code { get; set; }
    }
}