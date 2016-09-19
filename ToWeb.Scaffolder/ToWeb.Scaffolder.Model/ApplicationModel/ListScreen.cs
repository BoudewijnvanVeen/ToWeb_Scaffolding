using System;
using System.Collections.Generic;
using ToWeb.Scaffolder.Essentials.Model;
using ToWeb.Scaffolder.Essentials.Model.Attribute;

namespace ToWeb.Scaffolder.Models.ApplicationModel
{
    [Serializable()]
    [MapName("Views/{0}view", "Name")]
    public class ListScreen : ScaffolderBaseModel
    {
        public ListScreen()
        {
            Properties = new List<Property>();
        }

        public Entity Entity { get; set; }

        public List<Property> Properties { get; set; }
    }
}