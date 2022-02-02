namespace AccelByte.Sdk.Core.Repository
{
    public interface ITokenRepository
    {
        void StoreToken(string token);

        string GetToken();

        void RemoveToken();
    }
}