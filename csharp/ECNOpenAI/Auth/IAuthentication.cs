namespace ECNOpenAI.Auth
{
    public interface IAuthentication
    {
        string Key { get; }
        string? Organization { get; }
    }
}
