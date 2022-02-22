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
    /// setDefaultPolicy
    ///
    /// Update a localized version policy to be the default.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=4 (UPDATE)
    /// </summary>
    public class SetDefaultPolicy : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SetDefaultPolicyBuilder Builder = new SetDefaultPolicyBuilder();

        public class SetDefaultPolicyBuilder
        {
            
            internal SetDefaultPolicyBuilder() { }





            public SetDefaultPolicy Build(
                string localizedPolicyVersionId
            )
            {
                return new SetDefaultPolicy(this,
                    localizedPolicyVersionId                    
                );
            }
        }

        private SetDefaultPolicy(SetDefaultPolicyBuilder builder,
            string localizedPolicyVersionId
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            
            
            
            
            
        }
        #endregion

        public SetDefaultPolicy(
            string localizedPolicyVersionId            
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            
            
            
            
            
        }

        public override string Path => "/agreement/admin/localized-policy-versions/{localizedPolicyVersionId}/default";

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