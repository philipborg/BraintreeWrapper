using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace BrainTreeApi
{
    public static class Serializator
    {
        public static string ToSerialize<T>(T model, bool indent = false, bool omitXmlDeclaration = true, bool namespaces = false)
        {
            var stream = new MemoryStream();
            var serializer = new XmlSerializer(model.GetType());

            using (XmlWriter xw = XmlWriter.Create(stream, new XmlWriterSettings() { Indent = indent, OmitXmlDeclaration = omitXmlDeclaration }))
            {
                if(namespaces)
                    serializer.Serialize(xw, model, new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty }));
                else
                    serializer.Serialize(xw, model);
            }

            return Encoding.UTF8.GetString(stream.ToArray());
        }

        public static string SerializeRequest()
        {
            var model = new RequestModel
            {
                Message = Parser.GetPreparedData()
            };

            var obj = Serializator.ToSerialize(model, true, false, false);
            if (!string.IsNullOrEmpty(obj))
                Parser.AppendXml(obj);

            return Parser.GetPreparedData();
        }

        public static string SerializeResponse(string message = "")
        {
            var model = new ResponseModel
            {
                Message = Parser.GetPreparedData()
            };

            var obj = Serializator.ToSerialize(model, true, false, false);
            if (!string.IsNullOrEmpty(obj))
                Parser.AppendXml(obj);

            return Parser.GetPreparedData();
        }
    }
}