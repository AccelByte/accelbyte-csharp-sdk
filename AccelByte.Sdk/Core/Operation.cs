using System.Collections;
using System.Text;
using System.Web;

namespace AccelByte.Sdk.Core
{
    public abstract class Operation
    {
        public const string SECURITY_BASIC = "Basic";
        public const string SECURITY_BEARER = "Bearer";
        public const string COLLECTION_FORMAT_CSV = "csv";
        public const string COLLECTION_FORMAT_MULTI = "multi";
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

        public string GetUrl(string baseUrl)
        {
            return BuildUrl(baseUrl, Path, PathParams, QueryParams);
        }
        private string BuildUrl(string baseUrl, string path, Dictionary<string, string> pathParams, Dictionary<string, dynamic> queryParams) // TODO Move to helper
        {
            if (path == null) 
            {
                throw new ArgumentNullException(nameof(path));
            }
            
            if (baseUrl == null) 
            {
                throw new ArgumentNullException(nameof(baseUrl));
            }

            var url = new StringBuilder(baseUrl.TrimEnd('/'));

            if (pathParams != null)
            {
                foreach (var pp in pathParams)
                {
                    path = path.Replace("{" + pp.Key + "}", HttpUtility.UrlEncode(pp.Value));
                }
            }

            url.Append(path);

            if (queryParams != null && queryParams.Any())
            {
                url.Append("?");

                foreach (var qp in queryParams)
                {
                    if (qp.Value is IList)
                    {
                        var collectionFormat = string.Empty;

                        if (!CollectionFormatMap.TryGetValue(qp.Key, out collectionFormat)) 
                        {
                            collectionFormat = COLLECTION_FORMAT_CSV;   // Default collection format CSV
                        }

                        switch (collectionFormat)
                        {
                            case COLLECTION_FORMAT_CSV:
                                url.Append($"{HttpUtility.UrlEncode(qp.Key)}=");
                                foreach (var v in qp.Value) {
                                    var escapedValue = v.Replace("\"", "\"\"");    // Escape " if any
                                    url.Append($"{HttpUtility.UrlEncode($"\"{escapedValue}\"")},");
                                }
                                url.Length--;   // Trim end ","
                                url.Append("&");
                                break;
                            case COLLECTION_FORMAT_MULTI:
                                foreach (var v in qp.Value) 
                                {
                                    url.Append($"{HttpUtility.UrlEncode(qp.Key)}={HttpUtility.UrlEncode(v)}&");
                                }
                                break;
                            default:
                                throw new NotSupportedException($"Unsupported query collection format (format: {collectionFormat})");
                        }
                    }
                    else
                    {
                        url.Append($"{HttpUtility.UrlEncode(qp.Key)}={HttpUtility.UrlEncode(qp.Value)}&");
                    }
                }

                url.Length--;   // Trim end "&"
            }

            return url.ToString();
        }
    }
}
