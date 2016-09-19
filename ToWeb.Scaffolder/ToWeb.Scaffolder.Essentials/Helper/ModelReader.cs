using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ToWeb.Scaffolder.Essentials.Helper
{
    public class ModelReader<T> where T : class, new()
    {
        public T Read(string path)
        {
            T obj;

            using (var xmlStream = new FileStream(path, FileMode.Open))
            {
                using (var xmlReader = XmlReader.Create(xmlStream))
                {
                    // Create a new XmlSerializer instance with the type of the test class
                    var serializerObj = new XmlSerializer(typeof(T));

                    // Load the object saved above by using the Deserialize function
                    obj = (T)serializerObj.Deserialize(xmlReader);
                }
            }

            return obj;
        }

        public void Write(string path, T instance)
        {
            var writer = new XmlSerializer(typeof(T));

            var file = new StreamWriter(path);
            writer.Serialize(file, instance);
            file.Close();
        }
    }
}