// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// partialUpdatePolicy
    ///
    /// Update an existing base policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=4 (UPDATE)
    /// </summary>
    public class PartialUpdatePolicy : AccelByte.Sdk.Core.Operation
    {
        public PartialUpdatePolicy(
            string basePolicyId,            
            Model.UpdateBasePolicyRequest body            
        )
        {
            PathParams["basePolicyId"] = basePolicyId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/agreement/admin/base-policies/{basePolicyId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.UpdateBasePolicyResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UpdateBasePolicyResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UpdateBasePolicyResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}