// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// createPolicy
    ///
    /// Create a legal policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=1 (CREATE)
    /// </summary>
    public class CreatePolicy : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreatePolicyBuilder Builder { get => new CreatePolicyBuilder(); }

        public class CreatePolicyBuilder
            : OperationBuilder<CreatePolicyBuilder>
        {


            public Model.CreateBasePolicyRequest? Body { get; set; }




            internal CreatePolicyBuilder() { }



            public CreatePolicyBuilder SetBody(Model.CreateBasePolicyRequest _body)
            {
                Body = _body;
                return this;
            }




            public CreatePolicy Build(
            )
            {
                CreatePolicy op = new CreatePolicy(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private CreatePolicy(CreatePolicyBuilder builder
        )
        {
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreatePolicy(
            Model.CreateBasePolicyRequest body            
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/base-policies";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.CreateBasePolicyResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CreateBasePolicyResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CreateBasePolicyResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}