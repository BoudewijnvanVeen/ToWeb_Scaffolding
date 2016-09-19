
using System;

namespace ToWeb.Scaffolder.Essentials.Model.Attribute
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class MapName : System.Attribute
    {
        public MapName(string name)
        {
            FormatString = name;
        }

        public MapName(string formatString, string property)
        {
            Property = property;
            FormatString = formatString;
        }

        public string FormatString { get; set; }

        public string Property { get; set; }
    }
}
