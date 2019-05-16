using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherDashboard.Contracts.Builders;
using WeatherDashboard.Contracts.Enumerations;
using WeatherDashboard.Contracts.Extensions;
using WeatherDashboard.Contracts.Members;
using WeatherDashboard.DTO.CPTEC;

namespace WeatherDashboard.Contracts.Tests.ConvertionTests
{
    [TestClass]
    public class ConvertionsTests
    {
        private const string BaseUrl = "servicodados.ibge.gov.br/api/v1/localidades";

        private const string BaseUrl2 = "servicos.cptec.inpe.br/XML";

        [TestMethod]
        public async Task ConvertXmlToJsonString()
        {
            using (var urlBuilder = new WeatherDashboardUrlBuilder(BaseUrl2))
            {
                var url = urlBuilder.BuildBaseUrl(RequestProtocol.Http)
                    .AppendPath(CptecUrlMembers.Capitals)
                    .AppendPath(CptecUrlMembers.CurrentConditions, true)
                    .Build();

                var capitals =
                    await HttpResponseObjectBuilder.BuildWebXmlObject<Capitals>(url
                        , RestMethods.Get
                        , DecompressionMethods.None
                        , Encoding.GetEncoding("iso-8859-1"));

                Assert.IsFalse(string.IsNullOrEmpty(capitals.StringfyJsonObject()));

            }
        }

        [TestMethod]
        public async Task XmlToJsonObject()
        {
            using (var urlBuilder = new WeatherDashboardUrlBuilder(BaseUrl2))
            {
                var url = urlBuilder.BuildBaseUrl(RequestProtocol.Http)
                    .AppendPath(CptecUrlMembers.Capitals)
                    .AppendPath(CptecUrlMembers.CurrentConditions, true)
                    .Build();

                var capitals =
                    await HttpResponseObjectBuilder.BuildWebXmlObject<Capitals>(url
                        , RestMethods.Get
                        , DecompressionMethods.None
                        , Encoding.GetEncoding("iso-8859-1"));

                var capitalsObject = capitals.StringfyJsonObject().DeserializeJsonString<Capitals>();
                
                Assert.IsNotNull(capitalsObject);

            }
        }
    }
}
