using System;
using System.Collections.Generic;
using ToWeb.Scaffolder.Essentials.Model;

namespace ToWeb.Scaffolder.Models.ApplicationModel
{
    [Serializable()]
    public class TestModel : ScaffolderBaseModel
    {
        public TestModel()
        {
            Modules = new List<Module>();
        }

        public List<Module> Modules { get; set; }

        public Entities Entities { get; set; }
    }
}