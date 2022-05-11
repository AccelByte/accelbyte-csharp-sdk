// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Globalization;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Logging;

namespace AccelByte.Sdk.Core.Client
{
    public class ReliableHttpClient : IHttpClient
    {
        protected static List<int> _RedirectCodes = new List<int>() { 308, 307, 300, 301, 302, 303 };

        public static System.Net.Http.HttpClient? Http { get; private set; }

        #region Builder Part
        public static readonly ReliableHttpClientBuilder Builder = new ReliableHttpClientBuilder();

        public class ReliableHttpClientBuilder
        {
            public System.Net.Http.HttpClient? Http { get; private set; } = null;

            public HttpClientHandler? HttpHandler { get; private set; } = null;

            public HttpClientPolicy DefaultPolicy { get; private set; } = HttpClientPolicy.Default;

            public IHttpLogger? Logger { get; private set; } = null;

            public ReliableHttpClientBuilder SetHttp(System.Net.Http.HttpClient hcObj)
            {
                Http = hcObj;
                return this;
            }

            public ReliableHttpClientBuilder SetHttpClientHandler(HttpClientHandler handler)
            {
                HttpHandler = handler;
                return this;
            }

            public ReliableHttpClientBuilder SetDefaultPolicy(HttpClientPolicy policy)
            {
                DefaultPolicy = policy;
                return this;
            }

            public ReliableHttpClientBuilder SetLogger(IHttpLogger logger)
            {
                Logger = logger;
                return this;
            }

            public ReliableHttpClient Build()
            {
                return new ReliableHttpClient(this);
            }
        }
        #endregion

        private LoggingHandler? _LoggingHandler = null;

        private HttpClientPolicy _Policy;

        private ReliableHttpClient(ReliableHttpClientBuilder builder)
        {
            if (builder.Http != null)
                Http = builder.Http;
            else
            {
                if (builder.HttpHandler != null)
                {
                    _LoggingHandler = new LoggingHandler(builder.HttpHandler);
                    Http = new System.Net.Http.HttpClient(_LoggingHandler);
                }
                else
                {
                    _LoggingHandler = new LoggingHandler(new HttpClientHandler()
                    {
                        AllowAutoRedirect = false
                    });
                    Http = new System.Net.Http.HttpClient(_LoggingHandler);
                }
            }

            _Policy = builder.DefaultPolicy;
            if ((builder.Logger != null) && (_LoggingHandler != null))
                _LoggingHandler.Logger = builder.Logger;
        }

        public IHttpClient SetLogger(IHttpLogger logger)
        {
            if (_LoggingHandler != null)
                _LoggingHandler.Logger = logger;
            return this;
        }

        protected HttpRequestMessage CreateRequestMessage(Operation operation, string baseURL)
        {
            Dictionary<string, string> headers = operation.HeaderParams;

            var reqContentType = string.Empty;

            if (operation.Consumes.Any())
            {
                reqContentType = operation.Consumes.First();
                headers["Content-Type"] = reqContentType;
            }

            if (operation.Produces.Any())
                headers["Accept"] = operation.Produces.First();

            var url = operation.GetUrl(baseURL);
            var request = new HttpRequestMessage(operation.Method, url);

            if (operation.BodyParams != null)
            {
                if (reqContentType == String.Empty)
                {
                    reqContentType = "application/json";
                    headers["Content-Type"] = reqContentType;
                }

                if (IsMediaTypeJson(reqContentType))
                {
                    var jsonString = JsonSerializer.Serialize(operation.BodyParams);
                    request.Content = new StringContent(jsonString, Encoding.UTF8, reqContentType);
                }
                else
                {
                    var bodyString = operation.BodyParams.ToString()!;
                    request.Content = new StringContent(bodyString, Encoding.UTF8, reqContentType);
                }
            }
            else if (operation.FormParams.Any())
            {
                switch (reqContentType)
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
                            else if (kvp.Value is FileUploadStream fusStream)
                            {
                                StreamContent fsStream = new StreamContent(fusStream);
                                fsStream.Headers.ContentType = new MediaTypeHeaderValue(fusStream.MimeType);
                                content.Add(fsStream, kvp.Key, fusStream.FileName);
                            }
                            else if (kvp.Value is Stream stream)
                            {
                                StreamContent fsStream = new StreamContent(stream);
                                fsStream.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                                content.Add(fsStream, kvp.Key, "name.bin");
                            }
                            else
                            {
                                throw new NotSupportedException($"Unsupported multipart form data type (content type: {kvp.Value.GetType()})");
                            }
                        }
                        headers["Content-Type"] = ("multipart/form-data; boundary=" + boundary);
                        request.Content = content;
                        break;
                    default:
                        throw new NotSupportedException($"Unsupported form content type (content type: {reqContentType})");
                }
            }
            else
            {
                if (reqContentType == String.Empty)
                    reqContentType = "text/plain";
                request.Content = new StringContent(string.Empty, Encoding.UTF8, reqContentType);
            }

            foreach (var h in headers)
            {
                if (h.Key == "User-Agent")
                    request.Headers.UserAgent.ParseAdd(h.Value);
                else if (h.Key == "Accept")
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(h.Value));
                else if (h.Key == "Authorization")
                {
                    var authorization = h.Value.Split(' ');
                    request.Headers.Authorization = new AuthenticationHeaderValue(authorization[0], authorization[1]);
                }
                else
                    request.Headers.TryAddWithoutValidation(h.Key, h.Value);
            }

            return request;
        }

        public HttpResponse SendRequest(Operation operation, string baseURL)
        {
            if (Http == null)
                throw new Exception("HttpClient object is null.");

            HttpClientPolicy policy = _Policy;
            if (operation.HttpClientPolicy != null)
                policy = _Policy.MergeWith(operation.HttpClientPolicy);

            int retryCount = 0;
            while (true)
            {
                try
                {
                    HttpRequestMessage request = CreateRequestMessage(operation, baseURL);
                    if (policy.AddRetryCountToHeaders!.Value)
                        request.Headers.TryAddWithoutValidation("X-Client-Retry-Count", retryCount.ToString());

                    HttpResponseMessage response;
                    using (var cts = new CancellationTokenSource(policy.RequestTimeOut!.Value * 1000))
                    {
                        Task<HttpResponseMessage> sendTask = Http.SendAsync(request, cts.Token);
                        sendTask.Wait();
                        response = sendTask.Result;
                    }

                    string respContentType = String.Empty;
                    IEnumerable<string>? ctValues = null;
                    if (response.Headers.TryGetValues("Content-Type", out ctValues))
                        respContentType = String.Join(",", ctValues).Trim();

                    if (respContentType != String.Empty)
                    {
                        string[] ctSplits = respContentType.Split(';');
                        if (ctSplits.Length > 0)
                            respContentType = ctSplits[0].Trim();
                    }

                    int responseCode = (int)response.StatusCode;
                    if (_RedirectCodes.Contains(responseCode))
                    {
                        var location = response.Headers.Location ??
                                throw new Exception($"Location header is null (status code: {response.StatusCode})");

                        Stream payload = new MemoryStream(Encoding.UTF8.GetBytes(location.OriginalString));
                        return new HttpResponse(response.StatusCode, respContentType, payload);
                    }
                    else
                    {
                        Stream payload;
                        if (response.Content != null)
                            payload = response.Content.ReadAsStream();
                        else
                            payload = new MemoryStream();

                        if ((responseCode >= 200) && (responseCode < 300))
                        {
                            return new HttpResponse(response.StatusCode, respContentType, payload);
                        }
                        else
                        {
                            string sPayload = Helper.ConvertInputStreamToString(payload);
                            throw new HttpResponseException(response.StatusCode, sPayload);
                        }
                    }
                }
                catch (SocketException xSocket)
                {
                    if (policy.RetryLogicHandler != null)
                    {
                        if (!policy.RetryLogicHandler.ExecuteRetryLogic(policy, retryCount, xSocket))
                            throw xSocket;
                        else
                            retryCount++;
                    }
                    else
                        throw xSocket;
                }
                catch (HttpResponseException xHttpResp)
                {
                    if (policy.RetryLogicHandler != null)
                    {
                        if (!policy.RetryLogicHandler.ExecuteRetryLogic(policy, retryCount, xHttpResp))
                            throw xHttpResp;
                        else
                            retryCount++;
                    }
                    else
                        throw xHttpResp;
                }
                catch (TaskCanceledException xTask)
                {
                    if (policy.RetryLogicHandler != null)
                    {
                        HttpRequestTimeoutException toException = new HttpRequestTimeoutException(xTask);
                        if (!policy.RetryLogicHandler.ExecuteRetryLogic(policy, retryCount, toException))
                            throw new HttpResponseException(HttpStatusCode.RequestTimeout, "");
                        else
                            retryCount++;
                    }
                    else
                        throw new HttpResponseException(HttpStatusCode.RequestTimeout, "");
                }
                catch (AggregateException x)
                {
                    if (x.InnerException is TaskCanceledException)
                    {
                        if (policy.RetryLogicHandler != null)
                        {
                            HttpRequestTimeoutException toException = new HttpRequestTimeoutException(x.InnerException);
                            if (!policy.RetryLogicHandler.ExecuteRetryLogic(policy, retryCount, toException))
                                throw new HttpResponseException(HttpStatusCode.RequestTimeout, "");
                            else
                                retryCount++;
                        }
                        else
                            throw new HttpResponseException(HttpStatusCode.RequestTimeout, "");
                    }
                    else
                        throw new Exception(x.Message, x);
                }
                catch (Exception x)
                {
                    throw new Exception(x.Message, x);
                }
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
    }
}