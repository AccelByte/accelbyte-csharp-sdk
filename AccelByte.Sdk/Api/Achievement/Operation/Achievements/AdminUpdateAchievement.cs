using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Achievement.Operation
{
    public class AdminUpdateAchievement : AccelByte.Sdk.Core.Operation
    {
        public AdminUpdateAchievement(
            string achievementCode,            
            string namespace_,            
            Model.ModelsAchievementUpdateRequest body            
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsAchievementResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsAchievementResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}