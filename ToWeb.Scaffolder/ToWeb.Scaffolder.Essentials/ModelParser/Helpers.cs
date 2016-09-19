using System;
using System.IO;
using System.Linq;
using ToWeb.Scaffolder.Essentials.Model.Attribute;

namespace ToWeb.Scaffolder.Essentials.ModelParser
{
    public static class Helpers
    {
        public static string FileName(Model.ScaffolderBaseModel instance)
        {
            var filename = GetAttribute<FileName>(instance);
            if (string.IsNullOrWhiteSpace(filename)) return ((Model.ScaffolderBaseModel)instance).Name + instance.GetType().Name;
            return filename;
        }

        private static string MapName(object instance)
        {
            var mapName = GetAttribute<MapName>(instance);
            if (mapName.IndexOfAny(Path.GetInvalidPathChars()) >= 0)
                throw new Exception("Map and file names cannot contain invalid characters: " + mapName);
            return mapName;
        }

        private static string GetAttribute<T>(object instance)
        {
            var attr = Attribute.GetCustomAttributes(instance.GetType()).AsQueryable().SingleOrDefault(a => a is T);

            if (attr == null) return string.Empty;

            var formatstring = ((MapName)attr).FormatString;
            var property = ((MapName)attr).Property;

            if (property == null)
                return formatstring;

            var typeValue = instance.GetType().GetProperty(property).GetValue(instance);

            return string.Format(formatstring, typeValue); ;
        }
    }
}
