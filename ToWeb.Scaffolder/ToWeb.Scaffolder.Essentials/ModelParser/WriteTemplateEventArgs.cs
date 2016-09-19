using ToWeb.Scaffolder.Essentials.Model;

namespace ToWeb.Scaffolder.Essentials.ModelParser
{
    public class WriteTemplateEventArgs
    {
        public ScaffolderBaseModel Model { get; set; }
        public string PathToTemplate { get; set; }
        public string ResultFileName { get; set; }
    }
}