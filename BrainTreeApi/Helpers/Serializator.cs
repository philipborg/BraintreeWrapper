using System;
using System.IO;
using System.Xml.Serialization;

namespace BrainTreeApi
{
    public static class Serializator
    {
        public static string ToSerialize<T>(T model)
        {
            XmlSerializer serializer = new XmlSerializer(model.GetType());
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, model);

                return writer.ToString();
            }
        }
    }
}
