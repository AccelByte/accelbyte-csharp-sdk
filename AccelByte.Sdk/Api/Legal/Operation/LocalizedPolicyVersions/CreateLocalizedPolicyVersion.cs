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
    /// createLocalizedPolicyVersion
    ///
    /// Create a version of a particular country-specific policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=1 (CREATE)
    /// </summary>
    public class CreateLocalizedPolicyVersion : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateLocalizedPolicyVersionBuilder Builder = new CreateLocalizedPolicyVersionBuilder();

        public class CreateLocalizedPolicyVersionBuilder
        {
            
            public Model.CreateLocalizedPolicyVersionRequest? Body { get; set; }
            
            internal CreateLocalizedPolicyVersionBuilder() { }



            public CreateLocalizedPolicyVersionBuilder SetBody(Model.CreateLocalizedPolicyVersionRequest _body)
            {
                Body = _body;
                return this;
            }



            public CreateLocalizedPolicyVersion Build(
                string policyVersionId
            )
            {
                return new CreateLocalizedPolicyVersion(this,
                    policyVersionId                    
                );
            }
        }

        private CreateLocalizedPolicyVersion(CreateLocalizedPolicyVersionBuilder builder,
            string policyVersionId
        )
        {
            PathParams["policyVersionId"] = policyVersionId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public CreateLocalizedPolicyVersion(
            string policyVersionId,            
            Model.CreateLocalizedPolicyVersionRequest body            
        )
        {
            PathParams["policyVersionId"] = policyVersionId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/agreement/admin/localized-policy-versions/versions/{policyVersionId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.CreateLocalizedPolicyVersionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CreateLocalizedPolicyVersionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CreateLocalizedPolicyVersionResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}