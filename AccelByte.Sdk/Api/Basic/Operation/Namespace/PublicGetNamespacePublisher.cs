using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    public class PublicGetNamespacePublisher : AccelByte.Sdk.Core.Operation
    {
        public PublicGetNamespacePublisher(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/publisher";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.NamespacePublisherInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.NamespacePublisherInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}