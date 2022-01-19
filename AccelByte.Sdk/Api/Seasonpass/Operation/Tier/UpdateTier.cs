using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    public class UpdateTier : AccelByte.Sdk.Core.Operation
    {
        public UpdateTier(
            string id,            
            string namespace_,            
            string seasonId,            
            Model.TierInput body            
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers/{id}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.Tier? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Tier>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}