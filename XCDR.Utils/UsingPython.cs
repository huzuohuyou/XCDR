using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.IO;

namespace XCDR.Utils
{
    public class UsingPython
    {
        private ScriptRuntime pyRuntime = null;
        private dynamic obj = null;
        string MethodName { get; }
        public UsingPython(string fileName)
        {
            var options = new Dictionary<string, object>();
            options["Frames"] = true;
            options["FullFrames"] = true;
            pyRuntime = Python.CreateRuntime(options);
        }

        public object ExcuteScript(string fileName, object p1=null , object p2 = null, object p3 = null, object p4 = null, object p5 = null, object p6 = null, object p7 = null, object p8 = null)
        {
            try
            {
                string serverpath = AppDomain.CurrentDomain.BaseDirectory + string.Format("PyScripys\\{0}", fileName);//所引用python路径
                if (!File.Exists(serverpath))
                {
                    throw new Exception(string.Format("{0}文件不存在！", serverpath));
                }
                obj = pyRuntime.UseFile(serverpath);
                if (null != obj)
                {
                    Object result = obj.get_value(p1, p2, p3, p4, p5, p6, p7, p8);
                    return result;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
