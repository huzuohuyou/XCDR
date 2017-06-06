using Newtonsoft.Json;
using System.Collections.Generic;

namespace XCDR.Areas.JoinGroup.Models
{
    public class OriginalCondition<T>
    {
        public string PatientID { get; set; }
        public List<T> OriginalValue { get; set; }

        public string GetSerializedOriginalValue() {
            return JsonConvert.SerializeObject(OriginalValue);
        }
    }
}