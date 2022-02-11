using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// AdminDeleteTag
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:UGCCONFIG [DELETE]
    /// </summary>
    public class AdminDeleteTag : AccelByte.Sdk.Core.Operation
    {
        public AdminDeleteTag(
            string namespace_,            
            string tagId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["tagId"] = tagId;
            
            
            
            
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/tags/{tagId}";

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