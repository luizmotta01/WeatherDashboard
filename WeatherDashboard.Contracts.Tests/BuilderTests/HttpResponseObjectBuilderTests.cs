using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherDashboard.Contracts.Builders;
using WeatherDashboard.Contracts.Enumerations;
using WeatherDashboard.Contracts.Members;
using WeatherDashboard.DTO.CPTEC;
using WeatherDashboard.DTO.IBGE.Locations;

namespace WeatherDashboard.Contracts.Tests.BuilderTests
{

    [TestClass]
    public class HttpResponseObjectBuilderTests
    {
        
        private const string BaseUrl = "servicodados.ibge.gov.br/api/v1/localidades";

        private const string BaseUrl2 = "servicos.cptec.inpe.br/XML";

        [TestMethod]
        public async Task GetXmlObject()
        {
            using (var urlBuilder = new WeatherDashboardUrlBuilder( BaseUrl2))
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

               Assert.IsNotNull(capitals);

            }
        }

        [TestMethod]
        public async Task GetJsonObject()
        {
            using (var urlBuilder = new WeatherDashboardUrlBuilder(BaseUrl))
            {
                var url = urlBuilder.BuildBaseUrl(RequestProtocol.Http)
                    .AppendPath(IbgeMembers.Counties)
                    .Build();

                var states = await HttpResponseObjectBuilder.BuildWebJsonObject<List<County>>(url
                    , RestMethods.Get
                    , DecompressionMethods.GZip | DecompressionMethods.Deflate
                    , Encoding.UTF8);

                Assert.IsNotNull(states);
            }
        }



    }
}

