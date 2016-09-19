using System;
using System.Collections.Generic;
using ToWeb.Scaffolder.Essentials.Model;
using ToWeb.Scaffolder.Essentials.Model.Attribute;

namespace ToWeb.Scaffolder.Models.ApplicationModel
{
    [Serializable()]
    [MapName("Entities")]
    public class Entities : ScaffolderBaseModel
    {
        public List<Entity> Items { get; set; }
    }
}