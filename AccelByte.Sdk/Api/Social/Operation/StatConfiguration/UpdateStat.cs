using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    public class UpdateStat : AccelByte.Sdk.Core.Operation
    {
        public UpdateStat(
            string namespace_,            
            string statCode,            
            Model.StatUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/stats/{statCode}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.StatInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}