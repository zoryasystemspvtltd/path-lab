using ILab.Extensionss.Data.Models;

namespace PathlabApi.Data.Models;

public class Uom : LabModel, IGlobal
{
    public string? Code { get; set; }
}