using System;
using System.Collections.Generic;
using System.Text;

namespace H5TypeScriptIssue
{
    public class Demo
    {
        public void DoWork()
        {
            Console.WriteLine(string.Join(" ", GetMessages()));
        }

        public List<string> GetMessages()
        {
            return new List<string>(new string[] { "Hello", "World" });
        }
    }
}
