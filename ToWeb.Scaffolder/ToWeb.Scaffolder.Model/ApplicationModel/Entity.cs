using System;
using System.Collections.Generic;
using ToWeb.Scaffolder.Essentials.Model;

namespace ToWeb.Scaffolder.Models.ApplicationModel
{
    [Serializable()]
    public class Entity : ScaffolderBaseModel
    {
        public List<Property> Properties { get; set; }
    }
}