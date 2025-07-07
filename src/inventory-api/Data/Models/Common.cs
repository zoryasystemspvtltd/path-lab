using ILab.Extensionss.Data.Models;

namespace InventoryApi.Data.Models
{
    public class Enterprise : LabModel
    {
       
    }
    public class Category : LabModel
    {

    }
    public class UnitOfMeasure : LabModel
    {

    }
    public class Vendor : LabModel
    {
        public string? Contact { get; set; }
    }
}
