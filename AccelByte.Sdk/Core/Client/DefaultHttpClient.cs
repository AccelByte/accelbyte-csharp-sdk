using System.Globalization;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Text.Json;

namespace AccelByte.Sdk.Core.Client
{
    public class DefaultHttpClient : IHttpClient
    {
        private static readonly HttpClientHandler Handler = new HttpClientHandler() 
        { 
            AllowAutoRedirect = false   // Handle redirect manually
        };
        private static readonly System.Net.Http.HttpClient Http = new System.Net.Http.HttpClient(Handler);
        private static object HttpLock = new object();

        public HttpResponse SendRequest(Operation operation, string baseURL, Dictionary<string, string> headers)
        {
            lock (HttpLock)
            {
                var contentType = string.Empty;

                if (operation.Consumes.Any())
                {
                    contentType = operation.Consumes.First();   // XXX First only

                    headers["Content-Type"] = contentType;
                }

                if (operation.Produces.Any())
                {
                    headers["Accept"] = operation.Produces.First();    // XXX First only
                }

                var url = operation.GetUrl(baseURL);

                var request = new HttpRequestMessage(operation.Method, url);

                if (operation.BodyParams != null)
                {
                    if (IsMediaTypeJson(contentType))
                    {
                        var jsonString = JsonSerializer.Serialize(operation.BodyParams);

                        request.Content = new StringContent(jsonString, Encoding.UTF8, contentType);
                    }
                    else
                    {
                        var bodyString = operation.BodyParams.ToString()!;

                        request.Content = new StringContent(bodyString, Encoding.UTF8, contentType);
                    }
                }
                else if (operation.FormParams.Any())
                {
                    switch (contentType)
                    {
                        case "application/x-www-form-urlencoded":
                            var formUrlEncoded = operation.FormParams.ToDictionary(kvp => kvp.Key, kvp => (string)kvp.Value);
                            request.Content = new FormUrlEncodedContent(formUrlEncoded);
                            break;
                        case "multipart/form-data":
                            var boundary = $"Upload----{DateTime.Now.ToString(CultureInfo.InvariantCulture)}";
                            var content = new MultipartFormDataContent(boundary);
                            foreach (var kvp in operation.FormParams)
                            {
                                if (kvp.Value is string str)
                                {
                                    content.Add(new StringContent(str), kvp.Key);
                                }
                                else if (kvp.Value is Stream stream)
                                {
                                    content.Add(new StreamContent(stream), kvp.Key);
                                }
                                else
                                {
                                    throw new NotSupportedException($"Unsupported multipart form data type (content type: {kvp.Value.GetType()})");
                                }
                            }
                            request.Content = content;
                            break;
                        default:
                            throw new NotSupportedException($"Unsupported form content type (content type: {contentType})");
                    }
                }
                else
                {
                    if (contentType == String.Empty)
                        contentType = "text/plain";
                    request.Content = new StringContent(string.Empty, Encoding.UTF8, contentType);
                }

                request.Content.Headers.Clear();

                foreach (var h in headers)
                {
                    if (h.Key == "Authorization")
                    {
                        var authorization = h.Value.Split(' ');

                        Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(authorization[0], authorization[1]);
                    }
                    else if (h.Key == "Accept")
                    {
                        Http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(h.Value));
                    }
                    else
                    {
                        request.Content.Headers.TryAddWithoutValidation(h.Key, h.Value);
                    }
                }

                var response = Http.Send(request);

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

                return new HttpResponse(response.StatusCode, contentType, payload!);
            }
        }

        private static bool IsMediaTypeJson(string mediaType)
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