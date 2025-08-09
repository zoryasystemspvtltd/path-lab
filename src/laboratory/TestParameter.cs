using ILab.Extensionss.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laboratory.Data.Models
{
    public class TestParameter : LabModel
    { 
        [ForeignKey("TestMaster")]
        public virtual long? TestMasterId { get; set; }
        [JsonIgnore]
        public virtual TestMaster? TestMaster { get; set; }
        public string? NormalRange { get; set; }
        public string? Method { get; set; }
    }
}
