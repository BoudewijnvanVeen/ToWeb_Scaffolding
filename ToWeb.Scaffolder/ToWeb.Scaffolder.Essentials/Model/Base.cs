
using System;
using System.Xml.Serialization;

namespace ToWeb.Scaffolder.Essentials.Model
{
    [Serializable()]
    public class ScaffolderBaseModel
    {
        private string _name;

        [XmlAttribute("Name")]
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }

        private string _extention;

        [XmlAttribute("Extention")]
        public string Extention
        {
            get { return _extention ?? ""; }
            set { _extention = value; }
        }
    }
}