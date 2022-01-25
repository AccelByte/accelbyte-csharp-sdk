using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class QueryWallets : AccelByte.Sdk.Core.Operation
    {
        public QueryWallets(
            string namespace_,            
            string? currencyCode,            
            int? limit,            
            int? offset,            
            string? userId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (currencyCode != null) QueryParams["currencyCode"] = currencyCode;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (userId != null) QueryParams["userId"] = userId;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/wallets";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.WalletPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.WalletPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}