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
                var engine = Python.CreateEngine();
                var scope = engine.CreateScope();
                var source = engine.CreateScriptSourceFromString(pyContent);
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
                var engine = Python.CreateEngine();
                var scope = engine.CreateScope();
                var source = engine.CreateScriptSourceFromFile(fileName);
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
