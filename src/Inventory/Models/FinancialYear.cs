namespace Inventory.Models
{
    public class FinancialYear : PathLabModel
    {
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }        
    }
}