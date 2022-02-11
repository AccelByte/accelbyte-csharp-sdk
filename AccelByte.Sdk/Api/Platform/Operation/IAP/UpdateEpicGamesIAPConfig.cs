using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// updateEpicGamesIAPConfig
    ///
    /// Update epic games iap config. Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:IAP:CONFIG", action=4 (UPDATE)
    ///   *  Returns : updated epic games iap config
    /// </summary>
    public class UpdateEpicGamesIAPConfig : AccelByte.Sdk.Core.Operation
    {
        public UpdateEpicGamesIAPConfig(
            string namespace_,            
            Model.EpicGamesIAPConfigRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/epicgames";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.EpicGamesIAPConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.EpicGamesIAPConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EpicGamesIAPConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}