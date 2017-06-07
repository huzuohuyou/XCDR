using Newtonsoft.Json;
using System.Collections.Generic;

namespace XCDR.Areas.JoinGroup.Models
{
    public class OriginalCondition<T>
    {
        public string PatientID { get; set; }
        public List<T> OriginalList { get; set; }

        public string OriginalString
        {
            get
            {
                return JsonConvert.SerializeObject(OriginalList);
            }
        }

    }
}