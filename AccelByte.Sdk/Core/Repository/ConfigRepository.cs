namespace AccelByte.Sdk.Core.Repository
{
    public interface IConfigRepository
    {
        string BaseUrl { get; }

        string ClientId { get; }

        string ClientSecret { get; }
    }
}
