using System.Collections;
using System.Net;
using System.Text;
using System.Web;

namespace AccelByte.Sdk.Core
{
    public abstract class Operation
    {
        public const string SECURITY_BASIC = "Basic";
        public const string SECURITY_BEARER = "Bearer";

        public abstract string Path { get; }
        public abstract HttpMethod Method { get; }

        public abstract string[] Consumes { get; }

        public abstract string[] Produces { get; }

        public abstract string? Security { get; set; }

        public Dictionary<string, string> PathParams { get; } = new Dictionary<string, string>();

        public Dictionary<string, dynamic> QueryParams { get; } = new Dictionary<string, dynamic>();

        public Dictionary<string, string> HeaderParams { get; } = new Dictionary<string, string>();

        public Dictionary<string, dynamic> FormParams { get; } = new Dictionary<string, dynamic>();

        public Dictionary<string, string> CollectionFormatMap { get; } = new Dictionary<string, string>();

        public object? BodyParams { get; init; }

        public string? LocationQuery { get; init; }

        public string GetFullUrl(string baseUrl)
        {
            return CreateFullUrl(this.Path, baseUrl, PathParams, QueryParams);
        }
        private string CreateFullUrl(string url, string baseUrl, Dictionary<string, string> pathParams, Dictionary<string, dynamic> queryParams)
        {
            var result = new StringBuilder();

            if (baseUrl != null && baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Split("/")[0] + "//" + baseUrl.Split("/")[2];
            }
            result.Append(baseUrl);

            if (pathParams != null)
            {
                foreach (var pathParam in pathParams)
                {
                    url = url.Replace("{" + pathParam.Key + "}", HttpUtility.UrlEncode(pathParam.Value));
                }
                result.Append(url);
            }

            // query params
            var queryParamBuilder = new StringBuilder();

            foreach (var queryParam in queryParams)
            {
                if (queryParam.Value is IList)
                {
                    var queryStringFormat = string.Empty;

                    if (!CollectionFormatMap.TryGetValue(queryParam.Key, out queryStringFormat))
                    {
                        queryStringFormat = "csv";
                    }

                    if (queryStringFormat == "csv")
                    {
                        queryParamBuilder.Append("&");
                        queryParamBuilder.Append(HttpUtility.UrlEncode(queryParam.Key));
                        queryParamBuilder.Append("=");
                        foreach (var qsai in queryParam.Value)
                        {
                            queryParamBuilder.Append(HttpUtility.UrlEncode($"\"{qsai.Replace("\"", "\"\"")}\""));
                            queryParamBuilder.Append(",");
                        }
                    }
                    else if (queryStringFormat == "multi")
                    {
                        foreach (var qsai in queryParam.Value)
                        {
                            queryParamBuilder.Append("&");
                            queryParamBuilder.Append(HttpUtility.UrlEncode(queryParam.Key));
                            queryParamBuilder.Append("=");
                            queryParamBuilder.Append(HttpUtility.UrlEncode(qsai));
                        }
                    }
                    else
                    {
                        throw new NotSupportedException($"Unsupported query collection format (format: {queryStringFormat})");
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(queryParam.Value))
                    {
                        queryParamBuilder.Append("&");
                        queryParamBuilder.Append(HttpUtility.UrlEncode(queryParam.Key));
                        queryParamBuilder.Append("=");
                        queryParamBuilder.Append(HttpUtility.UrlEncode(queryParam.Value));
                    }
                }
            }
            result.Append("?");
            result.Append(queryParamBuilder);

            return result.ToString();
        }
    }
}
