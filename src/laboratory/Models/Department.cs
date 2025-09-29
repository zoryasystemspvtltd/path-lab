using System.ComponentModel.DataAnnotations;

namespace Laboratory.Models
{
    public class Department : LaboratoryModel
    {
        [MaxLength(20)]
        public string? Code { get; set; }
    }
}