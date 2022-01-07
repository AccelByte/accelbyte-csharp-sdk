namespace AccelByte.Sdk.Core.Client
{
    public interface HttpClient {
        HttpResponse SendRequest(Operation operation, String baseUrl, Dictionary<string,string> headers);
    }
}