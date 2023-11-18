namespace ECNOpenAI.Client
{
    public interface IClient
    {
        Uri Uri { get; }
        Dictionary<string, string> Headers { get; }
        string? Body { get; }
    }
}
