using System.Collections.Generic;
using System.Xml.Serialization;

namespace WeatherDashboard.DTO.CPTEC
{
    [XmlRoot(ElementName = "capitais")]
    public class Capitals
    {
        [XmlElement(ElementName = "metar")]
        public List<Capital> CapitalsList { get; set; }
    }
}
