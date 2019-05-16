using Newtonsoft.Json;
using WeatherDashboard.DTO.IBGE.Base;

namespace WeatherDashboard.DTO.IBGE.Locations
{
    public class MicroRegion : IbgeBaseProperties
    {
        [JsonProperty("mesorregiao")]
        public MesoRegion MesoRegion { get; set; }
    }
}
