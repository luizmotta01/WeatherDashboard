using Newtonsoft.Json;

namespace WeatherDashboard.DTO.IBGE.Base
{
    public abstract class IbgeBaseProperties
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sigla", NullValueHandling = NullValueHandling.Ignore)]
        public string Initials { get; set; }

        [JsonProperty("nome")]
        public string Name { get; set; }
    }
}
