using Laboratory.Models;
using System.Numerics;

namespace PathlabApi.Data.Models
{
    public interface IGlobal
    {
    }
    public interface IAssignable
    {
        long? ProjectId { get; set; }
        long? ParentId { get; set; }
        Department? Parent { get; set; }
    }
    public interface IApproval
    {
        bool? IsApproved { get; set; }
        DateTime? ApprovedDate { get; set; }
        string? ApprovedBy { get; set; }
    }
    public interface IAssets
    {
    }   

}
