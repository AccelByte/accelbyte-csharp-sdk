using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    public class SingleAdminDeleteChannel : AccelByte.Sdk.Core.Operation
    {
        public SingleAdminDeleteChannel(
            string channelId,            
            string namespace_            
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            
            
            
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}