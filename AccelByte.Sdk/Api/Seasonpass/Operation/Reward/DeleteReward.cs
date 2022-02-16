// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// deleteReward
    ///
    /// This API is used to delete a reward permanently, only draft season reward can be deleted.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SEASONPASS", action=8 (DELETE)
    /// </summary>
    public class DeleteReward : AccelByte.Sdk.Core.Operation
    {
        public DeleteReward(
            string code,            
            string namespace_,            
            string seasonId            
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            
            
            
            
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards/{code}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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