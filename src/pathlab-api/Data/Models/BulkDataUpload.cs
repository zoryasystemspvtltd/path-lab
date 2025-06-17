using ILab.Extensionss.Data.Models;

namespace PathlabApi.Data.Models
{
    public class BulkDataUpload : LabModel
    {       
        public required IFormFile File { get; set; }
        public required string Title { get; set; }
    }

    public class BulkResponse
    {
        public BulkResponse()
        {
            SuccessData = [];
            FailureData = [];
        }
        public List<string> SuccessData { get; set; }
        public List<string> FailureData { get; set; }
    }
   
}
