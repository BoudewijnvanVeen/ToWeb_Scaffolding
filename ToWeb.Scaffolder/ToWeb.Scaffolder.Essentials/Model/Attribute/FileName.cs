
using System;

namespace ToWeb.Scaffolder.Essentials.Model.Attribute
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class FileName : System.Attribute
    {
        public FileName(string formatString, string property)
        {
            Property = property;
            FormatString = formatString;
        }

        public string FormatString { get; set; }

        public string Property { get; set; }
    }
}