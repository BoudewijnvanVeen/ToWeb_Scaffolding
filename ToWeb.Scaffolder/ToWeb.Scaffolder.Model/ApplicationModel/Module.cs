using System;
using ToWeb.Scaffolder.Essentials.Model;
using ToWeb.Scaffolder.Essentials.Model.Attribute;

namespace ToWeb.Scaffolder.Models.ApplicationModel
{
    [Serializable()]
    [MapName("{0}", "Name")]
    public class Module : ScaffolderBaseModel
    {
        public Entity Entity { get; set; }

        public DetailScreen DetailScreen { get; set; }

        public ListScreen ListScreen { get; set; }
    }
}