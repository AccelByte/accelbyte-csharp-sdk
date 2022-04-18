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
    /// publishPolicyVersion
    ///
    /// Manually publish a version of a particular country-specific policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=4 (UPDATE)
    /// </summary>
    public class PublishPolicyVersion : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublishPolicyVersionBuilder Builder = new PublishPolicyVersionBuilder();

        public class PublishPolicyVersionBuilder
            : OperationBuilder<PublishPolicyVersionBuilder>
        {
            
            public bool? ShouldNotify { get; set; }
            
            internal PublishPolicyVersionBuilder() { }


            public PublishPolicyVersionBuilder SetShouldNotify(bool _shouldNotify)
            {
                ShouldNotify = _shouldNotify;
                return this;
            }




            public PublishPolicyVersion Build(
                string policyVersionId
            )
            {
                PublishPolicyVersion op = new PublishPolicyVersion(this,
                    policyVersionId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublishPolicyVersion(PublishPolicyVersionBuilder builder,
            string policyVersionId
        )
        {
            PathParams["policyVersionId"] = policyVersionId;
            
            if (builder.ShouldNotify != null) QueryParams["shouldNotify"] = Convert.ToString(builder.ShouldNotify)!;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublishPolicyVersion(
            string policyVersionId,            
            bool? shouldNotify            
        )
        {
            PathParams["policyVersionId"] = policyVersionId;
            
            if (shouldNotify != null) QueryParams["shouldNotify"] = Convert.ToString(shouldNotify)!;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/policies/versions/{policyVersionId}/latest";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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