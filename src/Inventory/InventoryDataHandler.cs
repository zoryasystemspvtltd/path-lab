using ILab.Extensionss.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Inventory
{
    public class InventoryDataHandler : LabDataHandler
    {
        public readonly InventoryDataHandler handler;
        public InventoryDataHandler(DbContext dbContext,
        ILogger<InventoryDataHandler> logger)
            : base(dbContext, logger)
        {

        }
    }
}
