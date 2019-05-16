using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeatherDashboard.Contracts.Enumerations;
using WeatherDashboard.Contracts.Extensions;

namespace WeatherDashboard.Contracts.Builders
{

    public static class HttpResponseObjectBuilder
    {
        public static async Task<T> BuildWebJsonObject<T>(string url, RestMethods method, DecompressionMethods decompressionMethods, Encoding encoding) where T : class, new()
        {
            return await (await MakeRequest(url, method,decompressionMethods,encoding)).DeserializeJsonStringAsync<T>();
        }

        public static async Task<T> BuildWebXmlObject<T>(string url, RestMethods method, DecompressionMethods decompressionMethods, Encoding encoding) where T : class, new()
        {
            return await (await MakeRequest(url, method, decompressionMethods,encoding)).DeserializeXmlStringAsync<T>();
        }

        private static async Task<string> MakeRequest(string url, RestMethods method, DecompressionMethods methods, Encoding encoding)
        {
            var request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = method.ToString().ToUpper();
            request.AutomaticDecompression = methods;
            using (var response = await request.GetResponseAsync())
            {
                using (var stream = response.GetResponseStream())
                using (var streamReader = new StreamReader(stream ?? throw new InvalidOperationException(), encoding))
                {
                    return await streamReader.ReadToEndAsync();
                }
            }
        }

    }
}
