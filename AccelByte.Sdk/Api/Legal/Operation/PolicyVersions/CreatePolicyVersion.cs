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
    /// createPolicyVersion
    ///
    /// Create a version of a particular country-specific policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=1 (CREATE)
    /// </summary>
    public class CreatePolicyVersion : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreatePolicyVersionBuilder Builder = new CreatePolicyVersionBuilder();

        public class CreatePolicyVersionBuilder
        {
            
            public Model.CreatePolicyVersionRequest? Body { get; set; }
            
            internal CreatePolicyVersionBuilder() { }



            public CreatePolicyVersionBuilder SetBody(Model.CreatePolicyVersionRequest _body)
            {
                Body = _body;
                return this;
            }



            public CreatePolicyVersion Build(
                string policyId
            )
            {
                return new CreatePolicyVersion(this,
                    policyId                    
                );
            }
        }

        private CreatePolicyVersion(CreatePolicyVersionBuilder builder,
            string policyId
        )
        {
            PathParams["policyId"] = policyId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public CreatePolicyVersion(
            string policyId,            
            Model.CreatePolicyVersionRequest body            
        )
        {
            PathParams["policyId"] = policyId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/agreement/admin/policies/{policyId}/versions";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.CreatePolicyVersionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CreatePolicyVersionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CreatePolicyVersionResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}