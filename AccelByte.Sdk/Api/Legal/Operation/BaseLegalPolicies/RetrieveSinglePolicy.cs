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
    /// retrieveSinglePolicy
    ///
    /// Retrieve a base policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=2 (READ)
    /// </summary>
    public class RetrieveSinglePolicy : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveSinglePolicyBuilder Builder = new RetrieveSinglePolicyBuilder();

        public class RetrieveSinglePolicyBuilder
        {
            
            internal RetrieveSinglePolicyBuilder() { }





            public RetrieveSinglePolicy Build(
                string basePolicyId
            )
            {
                return new RetrieveSinglePolicy(this,
                    basePolicyId                    
                );
            }
        }

        private RetrieveSinglePolicy(RetrieveSinglePolicyBuilder builder,
            string basePolicyId
        )
        {
            PathParams["basePolicyId"] = basePolicyId;
            
            
            
            
            
        }
        #endregion

        public RetrieveSinglePolicy(
            string basePolicyId            
        )
        {
            PathParams["basePolicyId"] = basePolicyId;
            
            
            
            
            
        }

        public override string Path => "/agreement/admin/base-policies/{basePolicyId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.RetrieveBasePolicyResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RetrieveBasePolicyResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RetrieveBasePolicyResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}