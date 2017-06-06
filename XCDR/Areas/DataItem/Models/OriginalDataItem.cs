using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XCDR.Areas.DataItem.Models
{
    public class OriginalDataItem
    {
        public string SDCode { get; set; }
        public string PatientId { get; set; }
        public string ItemCode { get; set; }
        public string OriginalValue { get; set; }

        public string GetOriginalValue() {
            return "";
        }
    }
}