using System;
using System.Text;
using WeatherDashboard.Contracts.Enumerations;
using WeatherDashboard.Contracts.Extensions;

namespace WeatherDashboard.Contracts.Builders
{
    
    public class WeatherDashboardUrlBuilder : IDisposable
    {
        protected static StringBuilder UrlStringBuilder = new StringBuilder();

        private string _body;

        public WeatherDashboardUrlBuilder(string body)
        {
            _body = body;
        }
        
        //private static string IbgeUrl { get; set; } = "servicodados.ibge.gov.br/api/v1/";

        public WeatherDashboardUrlBuilder BuildBaseUrl(RequestProtocol protocol)
        {
            if (string.IsNullOrEmpty(_body) || string.IsNullOrWhiteSpace(_body))
                throw new ArgumentNullException(nameof(_body));

            _body = _body.AppendProtocol(protocol);

            return this;
        }

        public WeatherDashboardUrlBuilder AppendPath(string path, bool lastPath = false)
        {
            _body = _body.AppendPath(path,lastPath);

            return this;
        }

        public string Build()
        {
            return _body;
        }

        
        public void Dispose()
        {
            _body = null;
            UrlStringBuilder = null;
            GC.Collect();
        }
    }
}
