using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminGetListBanReasonV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:BAN [READ]'
    /// 
    /// Ban reasons is the code available to justify ban assignment. It is applicable
    /// globally for any namespace.
    /// 
    /// action code : 10202
    /// </summary>
    public class AdminGetListBanReasonV3 : AccelByte.Sdk.Core.Operation
    {
        public AdminGetListBanReasonV3(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/bans/reasons";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.AccountcommonBanReasonsV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonBanReasonsV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonBanReasonsV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}