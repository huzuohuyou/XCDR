using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.IO;

namespace XCDR.Utils
{
    public class UsingPython
    {
        public object ExcuteScriptString(string pyContent, List<Param> paramList)
        {
            try
            {
                ScriptRuntime scriptRuntime = ScriptRuntime.CreateFromConfiguration();
                ScriptEngine rbEng = scriptRuntime.GetEngine("python");
                ScriptSource source = rbEng.CreateScriptSourceFromString(pyContent);//设置脚本文件 
                ScriptScope scope = rbEng.CreateScope();
                foreach (var item in paramList)
                {
                    scope.SetVariable(item.Name, item.FixValue);
                }
                source.Execute(scope);
                return scope.GetVariable("result").ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object ExcuteScriptFile(string fileName, List<Param> paramList)
        {
            try
            {
                ScriptRuntime scriptRuntime = ScriptRuntime.CreateFromConfiguration();
                ScriptEngine rbEng = scriptRuntime.GetEngine("python");
                ScriptSource source = rbEng.CreateScriptSourceFromFile(fileName);//设置脚本文件 
                ScriptScope scope = rbEng.CreateScope();
                foreach (var item in paramList)
                {
                    scope.SetVariable(item.Name, item.FixValue);
                }
                source.Execute(scope);
                return scope.GetVariable("result").ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
