using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XCDR.Utils;

namespace XCDR.Areas.XCDR.Controllers
{
    public class UsingPythonController : ApiController
    {
        public string PostTest(string pythonContent) {
            UsingPython python = new UsingPython();
            List<Param> list = new List<Param>() {
                new Param() {Name="first_name",Value="1.11" ,Type="double"},
                new Param() { Name="last_name",Value="2.34",Type="double"} };
            pythonContent = @"args1=last_name
args2=first_name
result=args1+args2";
            return python.ExcuteScriptString(pythonContent,list).ToString();
        }
    }
}
