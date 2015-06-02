using System;

namespace UrlSplitter
{
    public class UrlSplit
    {
        private const string PROTOCOL_SEPARATOR = "://";

        public Url Split(string url)
        {
            var newUrl = new Url();
            newUrl.Protocol = GetProtocolFrom(url);
            newUrl.Domain = GetDomainFrom(url);
            newUrl.Path = GetPathFrom(url);
            return newUrl;
        }

        private string GetProtocolFrom(string url)
        {
            var values = SplitUrl(url);
            return values[0];
        }
        
        private string GetDomainFrom(string url)
        {
            var values = SplitUrl(url);
            var domainPlusPath = values[1];
            return domainPlusPath.Replace("/" + values[2], string.Empty);
        }

        private string GetPathFrom(string url)
        {
            var values = SplitUrl(url);
            return values[2];
        }

        private string[] SplitUrl(string url)
        {
            var valuesUrlSplitted = new[] {string.Empty, string.Empty, string.Empty};
            if (!url.Contains(PROTOCOL_SEPARATOR))
            {
                return valuesUrlSplitted;
            }
            var values = url.Split(new[] { PROTOCOL_SEPARATOR }, StringSplitOptions.RemoveEmptyEntries);
            valuesUrlSplitted[0] = values[0];

            if (values.Length > 1)
            {
                valuesUrlSplitted[1] = values[1];
            }

            var path = values[1].Split(new[] {"/"}, StringSplitOptions.RemoveEmptyEntries);
            if (path.Length > 1)
            {
                valuesUrlSplitted[2] = path[1];
            }
            return valuesUrlSplitted;
        }
    }
}
