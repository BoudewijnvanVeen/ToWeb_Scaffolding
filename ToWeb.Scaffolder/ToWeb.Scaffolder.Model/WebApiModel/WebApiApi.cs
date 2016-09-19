using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ToWeb.Scaffolder.Essentials.Model;

namespace ToWeb.Scaffolder.Models.WebApiModel
{
    public class WebApiApi : ScaffolderBaseModel
    {
        public string Name { get; set; }

        public List<ControllerModel> Controllers { get; set; }
    }

    public class ControllerModel
    {
        public string Name { get; set; }

        public List<ActionModel> Actions { get; set; }
    }

    public class ActionModel
    {
        public string Name { get; set; }

        public string RelativeUri { get; set; }

        public string ReturnTypeName { get; set; }

        public Parameters InputParameters { get; set; }
    }

    public class Parameters : Collection<Parameter>
    {
        public string ToString(int format)
        {
            var sb = new StringBuilder();
            foreach (var parameter in Items)
            {
                sb.Append(parameter.ToString(format));
            }
            return sb.ToString();
        }
    }

    public class Parameter
    {
        public string TypeName { get; set; }

        public string Name { get; set; }

        public string ToString(int format) {
            switch (format)
            {
                case 1:
                    return TypeName + " " + Name;
                case 2:
                    return Name;
                default:
                    return TypeName;
            }
        }
    }
}
