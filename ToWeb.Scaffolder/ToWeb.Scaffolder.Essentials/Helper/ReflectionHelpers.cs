namespace ToWeb.Scaffolder.Essentials.Helper
{
    //public static class ReflectionHelpers
    //{
    //    public static void WalkObjectTree(string outputhPath, Base instance, Func<string, object, string> handlePropValue)
    //    {
    //        if (instance == null) return;

    //        outputhPath = handlePropValue(outputhPath, instance);

    //        var properties = instance.GetType().GetProperties();

    //        foreach (var property in properties)
    //        {
    //            if (property.CanRead)
    //            {
    //                if (property.PropertyType.Namespace != null && property.PropertyType.BaseType == typeof(Base))
    //                {
    //                    var propertyValue = property.GetValue(instance);

    //                    WalkObjectTree(outputhPath, (Base)propertyValue, handlePropValue);
    //                }
    //                else if (property.PropertyType.IsGenericType && property.PropertyType.Name.Equals("List`1") && property.PropertyType.GetProperty("Item").PropertyType.BaseType == typeof(Base))
    //                {
    //                    var propertyValue = property.GetValue(instance);

    //                    var numberOfListItems = (int)property.PropertyType.GetProperty("Count").GetValue(propertyValue, null);

    //                    for (var i = 0; i < numberOfListItems; i++)
    //                    {
    //                        object[] index = { i };

    //                        var propValue = property.PropertyType.GetProperty("Item").GetValue(propertyValue, index);

    //                        WalkObjectTree(outputhPath, (Base)propValue, handlePropValue);
    //                    }
    //                }
    //            }
    //        }
    //    }

        //private string HandlePropValue(string outputPath, object instance)
        //{
        //    var outputMap = string.Empty;
        //    try
        //    {
        //        if (!(instance is Base)) throw new Exception("Provided type is not of type ECareScaffolding.Base: " + instance.GetType());

        //        // Skip processing if template is not found, this is by design
        //        if (string.IsNullOrEmpty(((Base)instance).Extention)) return outputPath;
        //        var templatePath = Path.Combine(TemplateFolders.First(), instance.GetType().Name + "." + ((Base)instance).Extention + ".t4");
        //        if (!File.Exists(templatePath)) return outputPath;

        //        var projectNamespace = Context.ActiveProject.GetDefaultNamespace();

        //        outputMap = Path.Combine(outputPath, MapName(instance));

        //        AddFileFromTemplate(Path.Combine(outputMap, FileName(instance)), instance, projectNamespace);

        //        return outputMap;
        //    }
        //    catch (Exception ex)
        //    {
        //        WriteToLog(ex.GetBaseException().Message, ex.GetBaseException().StackTrace);

        //        return outputMap;
        //    }
        //}
    }
}