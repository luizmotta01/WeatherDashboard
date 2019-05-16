using System.Collections.Generic;
using System.Xml.Serialization;

namespace WeatherDashboard.DTO.CPTEC
{
    [XmlRoot(ElementName = "cidades")]
    public class Cities
    {
        [XmlElement(ElementName = "cidade")]
        public List<City> CitiesList { get; set; }
    }

}
