using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainTreeApi
{
    public static class Parser
    {
        static StringBuilder _stringBuilder;

        public static StringBuilder StringBuilder
        {
            get { return _stringBuilder ?? (_stringBuilder = new StringBuilder()); }
        }

        static Parser()
        {
            StringBuilder.Clear();
        }

        public static string GetPreparedData()
        {
            var data = StringBuilder.ToString();
            
            StringBuilder.Clear();
            
            return data;
        }

        public static void AppendXml(string xml)
        {
            StringBuilder.Append(xml);
        }
    }
}
