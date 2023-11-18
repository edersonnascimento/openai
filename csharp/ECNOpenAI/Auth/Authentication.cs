namespace ECNOpenAI.Auth
{
    public class Authentication : IAuthentication {
        public string Key { get; private set; }
        public string Organization { get; private set; }
        public Authentication(string organization, string key) {
            Organization = organization;
            Key = key;
        }
    }
}
