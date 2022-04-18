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
    /// retrieveLocalizedPolicyVersions
    ///
    /// Retrieve versions of a particular country-specific policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=2 (READ)
    /// </summary>
    public class RetrieveLocalizedPolicyVersions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveLocalizedPolicyVersionsBuilder Builder = new RetrieveLocalizedPolicyVersionsBuilder();

        public class RetrieveLocalizedPolicyVersionsBuilder
            : OperationBuilder<RetrieveLocalizedPolicyVersionsBuilder>
        {
            
            internal RetrieveLocalizedPolicyVersionsBuilder() { }





            public RetrieveLocalizedPolicyVersions Build(
                string policyVersionId
            )
            {
                RetrieveLocalizedPolicyVersions op = new RetrieveLocalizedPolicyVersions(this,
                    policyVersionId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RetrieveLocalizedPolicyVersions(RetrieveLocalizedPolicyVersionsBuilder builder,
            string policyVersionId
        )
        {
            PathParams["policyVersionId"] = policyVersionId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveLocalizedPolicyVersions(
            string policyVersionId            
        )
        {
            PathParams["policyVersionId"] = policyVersionId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/localized-policy-versions/versions/{policyVersionId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.RetrieveLocalizedPolicyVersionResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveLocalizedPolicyVersionResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveLocalizedPolicyVersionResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}