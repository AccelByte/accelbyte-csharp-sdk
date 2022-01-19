using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    public class UnBanUsers : AccelByte.Sdk.Core.Operation
    {
        public UnBanUsers(
            string namespace_,            
            Model.ADTOForUnbanUserAPICall body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/actions/unban";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if ( code == (HttpStatusCode)400 || code == (HttpStatusCode)404 || code == (HttpStatusCode)422 || code == (HttpStatusCode)500 )
            {
                var payloadString = Helper.ConvertInputStreamToString(payload);
                
                throw new HttpResponseException(code, payloadString);
            }
        }
    }
}