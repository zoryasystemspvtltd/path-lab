using ILab.Extensionss.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class FinancialYear : LabModel
    {
        [MaxLength(20)]
        public virtual string? Code { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }        
    }
}