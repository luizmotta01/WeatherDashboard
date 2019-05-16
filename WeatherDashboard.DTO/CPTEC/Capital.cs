using System.Xml.Serialization;

namespace WeatherDashboard.DTO.CPTEC
{
    [XmlRoot(ElementName = "metar")]
    public class Capital
    {
        [XmlElement(ElementName = "codigo")]
        public string Code { get; set; }

        [XmlElement(ElementName = "atualizacao")]
        public string UpdateDateTime { get; set; }

        [XmlElement(ElementName = "pressao")]
        public string AtmosphericPressure { get; set; }

        [XmlElement(ElementName = "temperatura")]
        public string Temperature { get; set; }

        [XmlElement(ElementName = "tempo")]
        public string Weather { get; set; }

        [XmlElement(ElementName = "tempo_desc")]
        public string WeatherDescription { get; set; }

        [XmlElement(ElementName = "umidade")]
        public string AirHumidity { get; set; }

        [XmlElement(ElementName = "vento_dir")]
        public string WindDirection { get; set; }

        [XmlElement(ElementName = "vento_int")]
        public string WindIntensity { get; set; }

        [XmlElement(ElementName = "intensidade")]
        public string Intensity { get; set; }
    }
}