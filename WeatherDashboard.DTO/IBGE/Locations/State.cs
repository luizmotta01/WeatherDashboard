using Newtonsoft.Json;
using WeatherDashboard.DTO.IBGE.Base;

namespace WeatherDashboard.DTO.IBGE.Locations
{
    public class State : IbgeBaseProperties
    {
        [JsonProperty("regiao")]
        public Region Region { get; set; }
    }
}