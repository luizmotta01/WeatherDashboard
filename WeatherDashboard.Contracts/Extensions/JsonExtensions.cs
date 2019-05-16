using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace WeatherDashboard.Contracts.Extensions
{
    public static class JsonExtensions
    {
        public static T DeserializeJsonString<T>(this string jsonString) => JsonConvert.DeserializeObject<T>(jsonString,new JsonSerializerSettings(){ContractResolver = new CamelCasePropertyNamesContractResolver()});

        public static async Task<T> DeserializeJsonStringAsync<T>(this string jsonString) => await Task.Run(() => JsonConvert.DeserializeObject<T>(jsonString));

        public static string StringfyJsonObject<T>(this T jsonObject) => JsonConvert.SerializeObject(jsonObject,new JsonSerializerSettings(){ContractResolver = new CamelCasePropertyNamesContractResolver()});

    }
}
