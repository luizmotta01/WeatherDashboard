using Newtonsoft.Json;
using WeatherDashboard.DTO.IBGE.Base;

namespace WeatherDashboard.DTO.IBGE.Locations
{
    public class County : IbgeBaseProperties
    {
        [JsonProperty("microrregiao")]
        public MicroRegion MicroRegion { get; set; }
    }
}
