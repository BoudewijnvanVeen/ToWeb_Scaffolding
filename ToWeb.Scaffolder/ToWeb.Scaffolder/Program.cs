
using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TextTemplating;
using ToWeb.Scaffolder.Essentials.ModelParser;
using static RazorEngine.Razor;
using Project = Microsoft.Build.Evaluation.Project;

namespace ToWeb.Scaffolder
{
    public class Scaffolder
    {
        private readonly Essentials.Model.ScaffolderBaseModel _model;
        private readonly string _templatesPath;
        private readonly string _vsProjectPath;
        private readonly IModelParser _modelParser;

        private CustomHost _host;
        private ITextTemplatingSessionHost _sessionhost;
        private Project _project;
        private string _outPutMap;

        public Scaffolder(Essentials.Model.ScaffolderBaseModel model, string templatesPath, string vsProjectPath, IModelParser modelParser)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            if (string.IsNullOrWhiteSpace(templatesPath))
                throw new ArgumentNullException(nameof(templatesPath));

            if (!Directory.Exists(templatesPath))
                throw new DirectoryNotFoundException(templatesPath);

            if (!Directory.GetFiles(templatesPath, "*.cshtml").Any())
                throw new Exception("No T4 templates found in:" + templatesPath);

            if (string.IsNullOrWhiteSpace(vsProjectPath))
                throw new ArgumentNullException(nameof(vsProjectPath));

            if (!Path.GetExtension(vsProjectPath).Equals(".csproj"))
                throw new Exception(vsProjectPath + " should point to a .csproj file");

            if (!File.Exists(vsProjectPath))
                throw new FileNotFoundException(vsProjectPath);

            if (modelParser == null)
                throw new ArgumentNullException(nameof(modelParser));

            _model = model;
            _templatesPath = templatesPath;
            _vsProjectPath = vsProjectPath;
            _modelParser = modelParser;
        }

        public void Go()
        {
            var projectMap = Path.GetDirectoryName(_vsProjectPath);
            _outPutMap = Path.Combine(projectMap, "Generated");
            Directory.CreateDirectory(_outPutMap);

            _project = new Project(_vsProjectPath);
            _project.AddItem("Folder", _outPutMap);

            _modelParser.Parse(_model, WriteTemplate);
        }

        public void WriteTemplate(WriteTemplateEventArgs args)
        {
            //Read the text template.
            var templatePath = Path.Combine(_templatesPath, args.PathToTemplate);
            if (!File.Exists(templatePath))
                throw new FileNotFoundException(templatePath);

            var template = File.ReadAllText(Path.Combine(templatePath));

            //Transform the text template.
            string generatedCode = Parse(template, args.Model);
            var outputFileName = args.ResultFileName;
            var outputFilePath = Path.Combine(_outPutMap, outputFileName);

            //Write the result to file
            File.WriteAllText(outputFilePath, generatedCode);
            _project.AddItem("Compile", outputFilePath);
            _project.Save();
        }

        static void DoSomething()
        {
            var p = new Microsoft.Build.Evaluation.Project(@"D:\Samples\Scaffolder\TestWebApplication\TestWebApplication.csproj");
            p.AddItem("Folder", @"D:\Samples\Scaffolder\TestWebApplication\test");
            p.AddItem("Compile", @"D:\Samples\Scaffolder\TestWebApplication\test\Class1.cs");
            p.Save();
        }

       
    }
}
