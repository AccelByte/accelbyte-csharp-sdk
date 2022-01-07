namespace AccelByte.Sdk.Core.Repository
{
    public interface ConfigRepository
    {
        string BaseUrl { get; }

        string ClientId { get; }

        string ClientSecret { get; }
    }
}
