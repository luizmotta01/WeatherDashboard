using System.Collections.Generic;
using System.Xml.Serialization;

namespace WeatherDashboard.DTO.CPTEC
{
    [XmlRoot(ElementName = "cidade")]
    public class CityBase
    {
        [XmlElement(ElementName = "nome")]
        public string Nome { get; set; }
        [XmlElement(ElementName = "uf")]
        public string Uf { get; set; }
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "cidade")]
    public class City : CityBase
    {
        [XmlElement(ElementName = "atualizacao", IsNullable = true)]
        public string Atualizacao { get; set; }

        [XmlElement(ElementName = "previsao", IsNullable = true)]
        public List<Prediction> Previsao { get; set; }
    }

    [XmlRoot(ElementName = "previsao")]
    public class Prediction
    {
        [XmlElement(ElementName = "dia")]
        public string Dia { get; set; }

        [XmlElement(ElementName = "tempo")]
        public string Tempo { get; set; }

        [XmlElement(ElementName = "maxima")]
        public string Maxima { get; set; }

        [XmlElement(ElementName = "minima")]
        public string Minima { get; set; }

        [XmlElement(ElementName = "iuv")]
        public string Iuv { get; set; }
    }
}