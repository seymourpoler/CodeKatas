using UrlSplitter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UrlSplitterTests
{
    [TestClass]
    public class UrlSplitTests
    {
        private UrlSplit _urlSplitter;

        [TestInitialize]
        public void SetUp()
        {
            _urlSplitter = new UrlSplit();
        }
        [TestMethod]
        public void UrlSplit_Split_return_empty_Url_when_url_string_is_empty_string()
        {
            var expected = new Url();
                 
            var result = _urlSplitter.Split(string.Empty);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void UrlSplit_Split_return_Url_when_url_string_has_http_protocol_and_domain()
        {
            var url = "http://www.google.es";
            var expected = new Url{Protocol = "http", Domain = "www.google.es"};

            var result = _urlSplitter.Split(url);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void UrlSplit_Split_return_Url_when_url_string_has_http_protocol_and_domain_and_path()
        {
            var url = "http://www.google.es/path";
            var expected = new Url { Protocol = "http", Domain = "www.google.es", Path = "path"};
            var urlSplitter = new UrlSplit();

            var result = _urlSplitter.Split(url);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void UrlSplit_Split_return_Url_when_url_string_has_http_protocol_and_domain_but_without_path()
        {
            var url = "http://www.google.es/";
            var expected = new Url { Protocol = "http", Domain = "www.google.es" };

            var result = _urlSplitter.Split(url);

            Assert.AreEqual(expected, result);
        }
    }
}
