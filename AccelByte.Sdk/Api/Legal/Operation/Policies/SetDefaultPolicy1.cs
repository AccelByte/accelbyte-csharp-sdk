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
    /// setDefaultPolicy_1
    ///
    /// Update a policy to be the default.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=4 (UPDATE)
    /// </summary>
    public class SetDefaultPolicy1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SetDefaultPolicy1Builder Builder = new SetDefaultPolicy1Builder();

        public class SetDefaultPolicy1Builder
        {
            
            internal SetDefaultPolicy1Builder() { }





            public SetDefaultPolicy1 Build(
                string policyId
            )
            {
                return new SetDefaultPolicy1(this,
                    policyId                    
                );
            }
        }

        private SetDefaultPolicy1(SetDefaultPolicy1Builder builder,
            string policyId
        )
        {
            PathParams["policyId"] = policyId;
            
            
            
            
            
        }
        #endregion

        public SetDefaultPolicy1(
            string policyId            
        )
        {
            PathParams["policyId"] = policyId;
            
            
            
            
            
        }

        public override string Path => "/agreement/admin/policies/{policyId}/default";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}