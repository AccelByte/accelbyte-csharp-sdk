using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// queryRewards_1
    ///
    /// This API is used to query rewards by criteria.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:REWARD", action=2 (READ)
    ///   *  Returns : the list of rewards
    /// </summary>
    public class QueryRewards1 : AccelByte.Sdk.Core.Operation
    {
        public QueryRewards1(
            string namespace_,            
            string? eventTopic,            
            int? limit,            
            int? offset,            
            string? sortBy            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (eventTopic != null) QueryParams["eventTopic"] = eventTopic;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy != null) QueryParams["sortBy"] = sortBy;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/rewards/byCriteria";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.RewardPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RewardPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RewardPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}