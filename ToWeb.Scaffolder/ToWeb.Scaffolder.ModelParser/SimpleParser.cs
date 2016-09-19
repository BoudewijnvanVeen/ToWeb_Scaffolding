
using System;
using ToWeb.Scaffolder.Essentials.Model;
using ToWeb.Scaffolder.Essentials.ModelParser;

namespace ToWeb.Scaffolder.ModelParser
{
    public class SimpleParser : IModelParser
    {
        public void Parse(ScaffolderBaseModel model, Action<WriteTemplateEventArgs> writeTemplate)
        {
            writeTemplate(new WriteTemplateEventArgs
            {
                Model = model,
                PathToTemplate = "Model.cshtml",
                ResultFileName = "Model.cs"
            });
        }
    }
}
