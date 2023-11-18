using ECNOpenAI.Auth;

namespace ECNOpenAI.Client
{
    public class AbstractClient : IClient
    {
        protected const string BASE_URL = "https://api.openai.com/v1/";

        public Uri Uri { get; private set; }
        public Dictionary<string, string> Headers => _headers;
        public string? Body { get; protected set; }

        private Dictionary<string, string> _headers = new Dictionary<string, string>();

        protected AbstractClient(string endpoint, IAuthentication authentication) {
            this.Uri = new Uri($"{BASE_URL}{endpoint}");
            this.AddHeader("Content-Type", "application/json");
            this.AddHeader("Authorization", $"Bearer {authentication.Key}");
            if(authentication.Organization != null) {
                this.AddHeader("OpenAI-Organization", authentication.Organization);
            }
        }

        protected void AddHeader(string key, string value)  => _headers.Add(key, value);
        protected void AddHeader(KeyValuePair<string, string> header) => _headers.Add(header.Key, header.Value);
    }
}
