using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WeatherDashboard.Contracts.Extensions
{
    public static class XmlExtensions
    {
        public static T DeserializeXmlString<T>(this string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            return (T) xmlSerializer.Deserialize(new StringReader(xmlString));
        }

        public static async Task<T> DeserializeXmlStringAsync<T>(this string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            return await Task.Run(() => (T) xmlSerializer.Deserialize(new StringReader(xmlString)));
        }
    }
}