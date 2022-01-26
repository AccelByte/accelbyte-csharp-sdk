namespace AccelByte.Sdk.Core.Client
{
    public interface IHttpClient
    {
        HttpResponse SendRequest(Operation operation, String baseUrl, Dictionary<string,string> headers);
    }
}