
using System;
using ToWeb.Scaffolder.Essentials.Model;

namespace ToWeb.Scaffolder.Essentials.ModelParser
{
    public interface IModelParser
    {
        void Parse(ScaffolderBaseModel model, Action<WriteTemplateEventArgs> WriteTemplate);
    }
}
