using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToWeb.Scaffolder.Models.SimpelModel;
using ToWeb.Scaffolder.Models.WebApiModel;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var model = getTestModel();

            var templatesPath = @"D:\ToWeb\Scaffolding\TargetProjects\ToWeb.WebApi.Proxy\Template\Views\";

            string vsProjectPath = @"D:\ToWeb\Scaffolding\TargetProjects\ToWeb.WebApi.Proxy\ToWeb.WebApi.Proxy\ToWeb.WebApi.Proxy.csproj";

            var modelParser = new ToWeb.Scaffolder.ModelParser.SimpleParser();


            var s = new ToWeb.Scaffolder.Scaffolder(model, templatesPath, vsProjectPath, modelParser);

            s.Go();

        }

        private WebApiApi getTestModel()
        {
            var parameter = new Parameter
            {
                Name = "ClientId",
                TypeName = "Guid"
            };

            var action = new ActionModel
            {
                Name = "GetClientById",
                RelativeUri = "api/Clienten/client/{0}",
                ReturnTypeName = "Client",
                InputParameters = new Parameters {parameter}
            };

            var controller = new ControllerModel
            {
                Name = "Clienten",
                Actions = new List<ActionModel> {action}
            };

            var model = new WebApiApi
            {
                Name = "TestWebApiModel",
                Controllers = new List<ControllerModel> {controller}
            };

            return model;
        }
    }
}
