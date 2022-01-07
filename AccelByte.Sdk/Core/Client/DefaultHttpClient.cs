using System.Net;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Text.Json;

namespace AccelByte.Sdk.Core.Client
{
    public class DefaultHttpClient : HttpClient
    {
        private static readonly HttpClientHandler _httpClientHandler = new HttpClientHandler() { AllowAutoRedirect = false };
        private static readonly System.Net.Http.HttpClient _httpClient = new System.Net.Http.HttpClient(_httpClientHandler);

        public HttpResponse SendRequest(Operation operation, string baseURL, Dictionary<string, string> headers)
        {
            var contentType = string.Empty;

            if (operation.Consumes.Any())
            {
                contentType = operation.Consumes.First(); // FIXME First only
                headers["Content-Type"] = contentType;
            }

            var url = operation.GetFullUrl(baseURL);

            var request = new HttpRequestMessage(operation.Method, url);

            if (operation.BodyParams != null)
            {
                if (IsMediaTypeApplicationJson(contentType))
                {
                    var jsonString = JsonSerializer.Serialize(operation.BodyParams);

                    request.Content = new StringContent(jsonString, Encoding.UTF8, contentType);
                }
                else
                {
                    request.Content = new StringContent(operation.BodyParams.ToString()!, Encoding.UTF8, contentType);
                }
            }
            else if (operation.FormParams.Any())
            {
                request.Content = new FormUrlEncodedContent(operation.FormParams);
            }
            else
            {
                request.Content = new StringContent(string.Empty, Encoding.UTF8, contentType);
            }

            request.Content.Headers.Clear();

            foreach (var h in headers)
            {
                if (h.Key == "Authorization")
                {
                    var authorization = h.Value.Split(' ');

                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(authorization[0], authorization[1]);
                }
                else if (h.Key == "Accept")
                {
                    _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(h.Value));
                }
                else
                {
                    request.Content.Headers.TryAddWithoutValidation(h.Key, h.Value);
                }
            }

            var response = _httpClient.Send(request);

            Stream? payload = null;

            if (IsHttpStatusCodeRedirect(response.StatusCode))
            {
                var location = response.Headers.Location ??
                        throw new Exception($"Location header is null (status code: {response.StatusCode})");

                payload = new MemoryStream(Encoding.UTF8.GetBytes(location.OriginalString));
            }
            else if (response.Content != null)
            {
                payload = response.Content.ReadAsStream();
            }

            return new HttpResponse(response.StatusCode, contentType, payload);
        }

        private static bool IsMediaTypeApplicationJson(string mediaType)
        {
            if (mediaType == MediaTypeNames.Application.Json)
            {
                return true;
            }

            if (mediaType.StartsWith("application/") && mediaType.EndsWith("+json"))
            {
                return true;
            }

            return false;
        }

        private static bool IsHttpStatusCodeRedirect(HttpStatusCode code)
        {
            return (new[] { 308, 307, 300, 301, 302, 303 }).Contains((int)code);
        }
    }
}