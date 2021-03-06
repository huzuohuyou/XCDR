﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCDR.Utils
{
    public class Param
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

        public dynamic FixValue{
            get {
                if (Type== "int")
                {
                    return Convert.ToInt32(Value);
                }else if (Type == "double")
                {
                    return Convert.ToDouble(Value);
                }
                else if (Type == "datetime")
                {
                    return Convert.ToDateTime(Value);
                }
                else
                {
                    return Value;
                }
            }
        }
    }
}
