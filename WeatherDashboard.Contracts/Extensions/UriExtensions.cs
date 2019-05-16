using System.Linq;
using System.Text;
using WeatherDashboard.Contracts.Builders;
using WeatherDashboard.Contracts.Enumerations;

namespace WeatherDashboard.Contracts.Extensions
{
    public static class UriExtensions
    {
        private static readonly StringBuilder UrlStringBuilder = new StringBuilder();

        public static string AppendProtocol(this string url, RequestProtocol requestProtocol)
        {
            return UrlStringBuilder
                .Clear()
                .Append(requestProtocol
                    .ToString()
                    .ToLower())
                .Append("://")
                .Append(url)
                .ToString();
        }

        public static string AppendPath(this string url, string path, bool lastPath = false)
        {
            UrlStringBuilder.Clear();

            if (!url.EndsWith("/"))
                UrlStringBuilder.Append(url).Append("/");

            url = UrlStringBuilder
                .Append(UrlStringBuilder.ToString().Contains(url) ? string.Empty : url)
                .Append(path.StartsWith("/")
                    ? path.Remove(0, 1)
                    : path)
                .Append(lastPath ? string.Empty : "/")
                .ToString();

            return url;
        }

        public static string AddQueryString(this string url, UrlParameter[] parameters)
        {
            UrlStringBuilder.Clear().Append("?");

            var urlParameters = parameters.ToList();

            urlParameters.ToList().ForEach(p =>
            {
                UrlStringBuilder.Append(p.ToString())
                    .Append(urlParameters.IndexOf(p) < urlParameters.Count - 1 
                        ? "&" 
                        : string.Empty);
            });

            return UrlStringBuilder.ToString();
        }

    }
}
