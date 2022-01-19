using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class AdminGetBulkUserByEmailAddressV3 : AccelByte.Sdk.Core.Operation
    {
        public AdminGetBulkUserByEmailAddressV3(
            string namespace_,            
            Model.ModelListEmailAddressRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/search/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelListUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListUserResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}