namespace AccelByte.Sdk.Core.Repository
{
    public interface TokenRepository
    {
        void StoreToken(string token);

        string GetToken();

        void RemoveToken();
    }
}