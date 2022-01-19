using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    public class PublicQueryUserStatItems : AccelByte.Sdk.Core.Operation
    {
        public PublicQueryUserStatItems(
            string namespace_,            
            string userId,            
            int? limit,            
            int? offset,            
            string? statCodes,            
            string? tags            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (statCodes != null) QueryParams["statCodes"] = statCodes;
            if (tags != null) QueryParams["tags"] = tags;
            
            
            
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/users/{userId}/statitems";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.UserStatItemPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserStatItemPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}