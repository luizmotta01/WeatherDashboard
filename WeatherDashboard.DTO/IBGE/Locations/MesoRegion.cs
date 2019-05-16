using Newtonsoft.Json;
using WeatherDashboard.DTO.IBGE.Base;

namespace WeatherDashboard.DTO.IBGE.Locations
{
    public class MesoRegion : IbgeBaseProperties
    {
        [JsonProperty("UF")]
        public State State { get; set; }
    }
}
