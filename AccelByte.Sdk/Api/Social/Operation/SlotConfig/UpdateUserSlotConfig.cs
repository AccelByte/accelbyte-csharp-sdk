using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// updateUserSlotConfig
    ///
    /// Update a user slot configuration in given namespace.
    /// Other detail info:
    /// 
    ///     *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SLOTCONFIG", action=4 (UPDATE)
    ///     *  Returns : updated slot config
    /// </summary>
    public class UpdateUserSlotConfig : AccelByte.Sdk.Core.Operation
    {
        public UpdateUserSlotConfig(
            string namespace_,            
            string userId,            
            Model.SlotConfigUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/social/admin/namespaces/{namespace}/users/{userId}/config";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.UserSlotConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserSlotConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserSlotConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}