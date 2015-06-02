namespace UrlSplitter
{
    public class Url
    {
        public string Protocol { get; set; }
        public string Domain { get; set; }
        public string Path { get; set; }

        public Url()
        {
            Protocol = string.Empty;
            Domain = string.Empty;
            Path = string.Empty;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            var url = obj as Url;
            if (url == null)
            {
                return false;
            }
            return Protocol == url.Protocol &&
                   Domain == url.Domain &&
                   Path == url.Path;
        }
    }
}
