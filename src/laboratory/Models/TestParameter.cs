using ILab.Extensionss.Data.Models;
using Laboratory;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laboratory.Models
{
    public class TestParameter : LaboratoryModel
    { 
        [ForeignKey("TestMaster")]
        public virtual long? TestMasterId { get; set; }
        [JsonIgnore]
        public virtual TestMaster? TestMaster { get; set; }
        public string? NormalRange { get; set; }
        public string? Method { get; set; }
    }
}
