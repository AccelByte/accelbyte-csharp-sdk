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
    /// partialUpdatePolicy
    ///
    /// Update an existing base policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=4 (UPDATE)
    /// </summary>
    public class PartialUpdatePolicy : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PartialUpdatePolicyBuilder Builder { get => new PartialUpdatePolicyBuilder(); }

        public class PartialUpdatePolicyBuilder
            : OperationBuilder<PartialUpdatePolicyBuilder>
        {


            public Model.UpdateBasePolicyRequest? Body { get; set; }




            internal PartialUpdatePolicyBuilder() { }



            public PartialUpdatePolicyBuilder SetBody(Model.UpdateBasePolicyRequest _body)
            {
                Body = _body;
                return this;
            }




            public PartialUpdatePolicy Build(
                string basePolicyId
            )
            {
                PartialUpdatePolicy op = new PartialUpdatePolicy(this,
                    basePolicyId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PartialUpdatePolicy(PartialUpdatePolicyBuilder builder,
            string basePolicyId
        )
        {
            PathParams["basePolicyId"] = basePolicyId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PartialUpdatePolicy(
            string basePolicyId,
            Model.UpdateBasePolicyRequest body
        )
        {
            PathParams["basePolicyId"] = basePolicyId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/base-policies/{basePolicyId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

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